using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Models;
using DAL;
using System.Data.SqlClient;
using System.Threading;

namespace AttReport
{
    public partial class FrmMain : Form
    {
        private AttRecord objAttRecord = new AttRecord();
        private AttRecordService objAttRecordService = new AttRecordService();

        public FrmMain()
        {
            InitializeComponent();
            //加密SQL连接字符串
            //string connstring = DAL.SQLHelper.connString;
            //connstring = Common.StringSecurity.DESEncrypt(connstring);
            dgvAttLog.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;//第5列靠左
        }

        //数据源委托
        public delegate void SetDataSource(DataTable attLogTable);
        SetDataSource objSetDataSource;
        //Lbl提示委托
        public delegate void UpdataLbl(string str);
        UpdataLbl objUpdataLbl;
        //进度条委托
        public delegate void StartPrg(int cNumber);
        StartPrg objStartPrg;

        bool bIsConnected = false;//声明一个布尔变量，用于设备连接
        int iMachineNumber = 1;//设备的序列号。在连接设备之后，这个值将被改变
        int iValue = 0;//设备记录数        
        int cNumber = 0;//循环记数        

        int idwErrorCode = 0;//异常代码
        //int iGLCount = 0;
        //int iIndex = 0;

        //实例化API
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

        #region 委托的实现方法        

        //进度条进度委托实现方法
        public void startPrg(int cValue)
        {
            prgDownload.Value = cValue;//设置当前值
        }

        //dgv委托更新显示实现方法
        public void dgvDataSource(DataTable AttLogTable)
        {
            //更新dgvAttLog
            dgvAttLog.DataSource = AttLogTable;
        }

        #endregion

        #region 连接考勤机的事件
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtIP.Text.Trim() == "" || txtPort.Text.Trim() == "")
            {
                MessageBox.Show("IP或端口不能为空！", "Error");
                return;
            }
            int idwErrorCode = 0;

            Cursor = Cursors.WaitCursor;
            if (btnConnect.Text == "断开")
            {
                axCZKEM1.Disconnect();
                bIsConnected = false;
                btnConnect.Text = "Connect";
                lblState.Text = "设备等待连接";
                Cursor = Cursors.Default;
                return;
            }

            bIsConnected = axCZKEM1.Connect_Net(txtIP.Text, Convert.ToInt32(txtPort.Text));
            if (bIsConnected == true)
            {
                btnConnect.Text = "断开";
                btnConnect.Refresh();
                lblState.Text = "设备等待连接";
                iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("无法连接设备，错误代码=" + idwErrorCode.ToString(), "Error");
            }
            lblState.Text = "连接成功！";
            Cursor = Cursors.Default;
        }
        #endregion

        #region 保存记录的事件
        private void btnGetLog_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("请连接设备！", "Error");
                return;
            }
            btnConnect.Enabled = false;//关闭连接按钮
            btnGetLog.Enabled = false;//关闭下载按钮
            Cursor = Cursors.WaitCursor;//设置鼠标状态
            axCZKEM1.EnableDevice(iMachineNumber, false);//设置设备状态为关闭

            //获取记录数
            if (axCZKEM1.GetDeviceStatus(iMachineNumber, 6, ref iValue)) //这里我们使用函数“GetDeviceStatus”来获取记录的计数，“status”参数是6。
            {
                //设置进度条的值
                setPrg(iValue, 1);//参数：maxValue是最大长度值，stepNumber是每次增长值

                //取得记录
                if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//将记录读入内存
                {
                    //多线程下载记录
                    Thread objThread = new Thread(new ThreadStart(getDateTable));
                    objThread.Start();//线程开始
                    //判断线程
                    if (objThread.ThreadState == ThreadState.Suspended)
                    {
                        axCZKEM1.EnableDevice(iMachineNumber, true);//设置设备状态为开启
                        btnConnect.Enabled = true;//开启连接按钮
                        btnGetLog.Enabled = true;//开起下载按钮
                    }
                }
                else
                {
                    Cursor = Cursors.Default;
                    axCZKEM1.GetLastError(ref idwErrorCode);

                    if (idwErrorCode != 0)
                    {
                        MessageBox.Show("从终端读取数据失败,错误代码: " + idwErrorCode.ToString(), "Error");
                    }
                    else
                    {
                        axCZKEM1.GetLastError(ref idwErrorCode);
                        MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
                    }
                }
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);//获取异常代码
                MessageBox.Show("操作失败，错误代码：" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;//线程开启后恢复鼠标
        }
        #endregion

        #region lblState控件值的修改方法       

        //lblState控件值的修改方法
        public void LblState(string msg)
        {
            lblState.Text = msg;
        }
        #endregion

        #region 添加行号的方法
        //添加行号
        private void dgvAttLog_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Common.DataGridViewStyle.DgvRowPostPaint(this.dgvAttLog, e);
        }
        #endregion

        #region 记录下载保存的方法
        public void getDateTable()
        {
            //初始化记录变量
            string sdwEnrollNumber = "";//考勤记录的用户ID
            int idwVerifyMode = 0;//验证方式，0代表密码，1代表指纹，2代表ID卡
            int idwInOutMode = 0;//考勤状态,255代表无考勤状态
            int idwYear = 0;//年
            int idwMonth = 0;//月
            int idwDay = 0;//日
            int idwHour = 0;//时
            int idwMinute = 0;//分
            int idwSecond = 0;//秒
            int idwWorkcode = 0;//记录的Workcode值

            //实例化委托
            objUpdataLbl = new UpdataLbl(LblState);
            objStartPrg = startPrg;//实例Prg委托

            #region 创建DataTable表

            //创建一个名为"AttLogTable"的DataTable表
            DataTable AttLogTable = new DataTable();

            //设定列数据
            AttLogTable.Columns.Add("ClockId", typeof(int));
            AttLogTable.Columns.Add("MachineId", typeof(int));
            AttLogTable.Columns.Add("VerifyMode", typeof(int));
            AttLogTable.Columns.Add("InOutMode", typeof(int));
            AttLogTable.Columns.Add("ClockRecord", typeof(string));
            //清空DataTable行数据
            AttLogTable.Rows.Clear();

            #endregion

            //异步修改lbl值
            BeginInvoke(objUpdataLbl, "正在下载记录……");

            while (axCZKEM1.SSR_GetGeneralLogData(iMachineNumber, out sdwEnrollNumber, out idwVerifyMode,
                           out idwInOutMode, out idwYear, out idwMonth, out idwDay, out idwHour, out idwMinute, 
                           out idwSecond, ref idwWorkcode))//从内存取得记录
            {
                cNumber++;//循环记数，当前开写入的记录进度数
                BeginInvoke(objStartPrg, cNumber);//异步执行，实现进度条更新进度

                BeginInvoke(objUpdataLbl, cNumber + "/" + iValue);//异步修改lbl值

                //把记录循环写入DataTable表
                DataRow dr = AttLogTable.NewRow();
                dr[0] = sdwEnrollNumber;
                dr[1] = iMachineNumber;
                dr[2] = idwVerifyMode;
                dr[3] = idwInOutMode;
                dr[4] = idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() 
                    + ":" + idwMinute.ToString() + ":" + idwSecond.ToString();
                AttLogTable.Rows.Add(dr);
            }
            objSetDataSource = dgvDataSource;//实例委托            
            BeginInvoke(objSetDataSource, AttLogTable);//更新dgvAttLog

            //异步修改lbl值
            BeginInvoke(objUpdataLbl, "下载完毕！正在筛选记录……");

            #region 数据批量对比去重

            //读取数据库已有数据
            DataTable PastLogTable = objAttRecordService.GetAllOriginalLog().Tables[0];

            //求差集结果，
            IEnumerable<DataRow> drResult = AttLogTable.AsEnumerable().Except(PastLogTable.AsEnumerable(), DataRowComparer.Default);

            //处理空结果的异常
            if (drResult.Count() > 0)//如果序列元素的个数>0，则写入数据，否则跳过
            {
                //接收不重复的数据
                DataTable dtResult = drResult.CopyToDataTable();
                //批量写入原始记录表
                SQLHelper.UpdataByBulk(dtResult, "OriginalLog");
                //批量写入记录备份表
                SQLHelper.UpdataByBulk(dtResult, "OriginalLog_Bak");

                //异步修改lbl值
                BeginInvoke(objUpdataLbl, "数据保存成功！");
            }

            #endregion

            //清空dt对象
            AttLogTable = null;
            PastLogTable = null;
            //异步修改lbl值
            BeginInvoke(objUpdataLbl, "数据保存成功！");

        }
        #endregion

        #region 进度条值设置方法
        public void setPrg(int maxValue, int stepNumber)
        {
            //进度条
            prgDownload.Maximum = maxValue;//设置最大长度值
            prgDownload.Step = stepNumber;//设置每次增长多少
        }
        #endregion

        /***************************************************************************************************/
        #region 测试专用事件

        //测试事件
        private void btnTest_Click(object sender, EventArgs e)
        {
            //string dateTest = "12月";
            //DateTime Month = DateTime.Parse(dateTest);
            //设置结束值为上月最后1天的最后1秒
            //DateTime EndDate = DateTime.Today.AddDays(1 - DateTime.Today.Day).AddHours(9);//设置值为本月第1天上午9点

            DayOfWeek Test = DateTime.Now.DayOfWeek;
            MessageBox.Show(Test.ToString());
        }

        #endregion
        /***************************************************************************************************/

        //让窗体在容器panle2的中间位置
        private void FormStarPosition(Form objForm)
        {
            objForm.Location = new Point(
                Location.X + splitContainer1.Panel1.Width + (splitContainer1.Panel2.Width - objForm.Width) / 2 + 20,
                Location.Y + (splitContainer1.Panel2.Height - objForm.Height) / 2 + 100);
        }

        //员工入职窗口对象
        public static FrmAddStaff objFrmAddStaff = null;

        //员工入职菜单事件
        private void 员工入职ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmAddStaff == null)
            {
                objFrmAddStaff = new FrmAddStaff();
                objFrmAddStaff.Show();
            }
            else
            {
                objFrmAddStaff.Activate();//激活只能在最小化的时候起作用
                objFrmAddStaff.WindowState = FormWindowState.Normal;
            }
            FormStarPosition(objFrmAddStaff);
        }

        //员工信息窗口对象
        public static FrmStaffInfo objStaffInfo = null;

        //员工信息菜单事件
        private void 员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objStaffInfo == null)
            {
                objStaffInfo = new FrmStaffInfo();
                objStaffInfo.Show();
            }
            else
            {
                objStaffInfo.Activate();//激活只能在最小化的时候起作用
                objStaffInfo.WindowState = FormWindowState.Normal;
            }
        }

        //部门信息窗口对象
        public static FrmDtManage objFrmDtManage = null;

        //部门信息菜单事件
        private void 部门信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmDtManage == null)
            {
                objFrmDtManage = new FrmDtManage();
                objFrmDtManage.Show();
            }
            else
            {
                objFrmDtManage.Activate();//激活只能在最小化的时候起作用
                objFrmDtManage.WindowState = FormWindowState.Normal;
            }
        }

        //班次管理窗口对象
        public static FrmShiftTimes objFrmShiftTimes = null;

        //班次管理菜单事件
        private void 班次管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmShiftTimes == null)
            {
                objFrmShiftTimes = new FrmShiftTimes();
                objFrmShiftTimes.Show();
            }
            else
            {
                objFrmShiftTimes.Activate();//激活只能在最小化的时候起作用
                objFrmShiftTimes.WindowState = FormWindowState.Normal;
            }
        }

        //时段管理窗口对象
        public static FrmSfWorkTime objFrmSfWorkTime = null;

        //时段管理菜单事件
        private void 时段管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmSfWorkTime == null)
            {
                objFrmSfWorkTime = new FrmSfWorkTime();
                objFrmSfWorkTime.Show();
            }
            else
            {
                objFrmSfWorkTime.Activate();
                objFrmSfWorkTime.WindowState = FormWindowState.Normal;
            }
        }

        //职位管理窗口对象
        public static FrmJobs objFrmJobs = null;

        //职位信息菜单事件
        private void 职位信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmJobs == null)
            {
                objFrmJobs = new FrmJobs();
                objFrmJobs.Show();
            }
            else
            {
                objFrmJobs.Activate();
                objFrmJobs.WindowState = FormWindowState.Normal;
            }
        }

        //月报查询窗口对象
        public static FrmMonthReport objFrmMonthReport = null;

        //月报查询菜单事件
        private void 月报查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmMonthReport == null)
            {
                objFrmMonthReport = new FrmMonthReport();
                objFrmMonthReport.Show();
            }
            else
            {
                objFrmMonthReport.Activate();//激活窗口并给焦点
                objFrmMonthReport.WindowState = FormWindowState.Normal;
            }
        }

        //日报查询窗口对象
        public static FrmDayReport objFrmDayReport = null;

        //日报查询菜单事件
        private void 日报查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmDayReport == null)
            {
                objFrmDayReport = new FrmDayReport();
                objFrmDayReport.Show();
            }
            else
            {
                objFrmDayReport.Activate();//激活窗口并给焦点
                objFrmDayReport.WindowState = FormWindowState.Normal;
            }
        }

        //签卡处理
        public static FrmSignCard objFrmSignCard = null;
        private void 签卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmSignCard == null)
            {
                objFrmSignCard = new FrmSignCard();
                objFrmSignCard.Show();
            }
            else
            {
                objFrmSignCard.Activate();//激活窗体
                objFrmSignCard.WindowState = FormWindowState.Normal;
            }
        }

        private void 导入员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = dialog.FileName;
                var sfList = ImportDataFromExcel.GetStudentByExcel(path);

                if (sfList.Count > 0)
                {
                    ImportDataFromExcel.Import(sfList);

                    MessageBox.Show("导入成功！");
                }
            }
        }
    }
}
