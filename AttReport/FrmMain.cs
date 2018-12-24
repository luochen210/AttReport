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
            //cboMonth.Text = DateTime.Today.Month.ToString() + "月";

            //加密SQL连接字符串
            //string connstring = DAL.SQLHelper.connString;
            //connstring = Common.StringSecurity.DESEncrypt(connstring);
        }

        int idwErrorCode = 0;

        //声明委托
        public delegate void GetDataTable();
        public delegate void UpdataLbl(string msg);

        //根据委托创建对象
        GetDataTable objGetDataTable;
        UpdataLbl objUpdataLbl;

        private bool bIsConnected = false;//声明一个布尔变量，用于设备连接
        private int iMachineNumber = 1;//设备的序列号。在连接设备之后，这个值将被改变

        //实例化API
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

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
                lblState.Text = "设备状态：等待连接";
                Cursor = Cursors.Default;
                return;
            }

            bIsConnected = axCZKEM1.Connect_Net(txtIP.Text, Convert.ToInt32(txtPort.Text));
            if (bIsConnected == true)
            {
                btnConnect.Text = "断开";
                btnConnect.Refresh();
                lblState.Text = "设备状态：等待连接！";
                iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("无法连接设备，错误代码=" + idwErrorCode.ToString(), "Error");
            }
            lblState.Text = "设备状态：连接成功！请下载记录……";
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

            Cursor = Cursors.WaitCursor;

            objGetDataTable = iDateTable;

            axCZKEM1.EnableDevice(iMachineNumber, false);//设置设备状态为关闭
            if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//将记录读入内存
            {
                //异步取得记录
                BeginInvoke(objGetDataTable);
            }
            else
            {
                Cursor = Cursors.Default;
                axCZKEM1.GetLastError(ref idwErrorCode);

                if (idwErrorCode != 0)
                {
                    MessageBox.Show("Reading data from terminal failed,ErrorCode: " + idwErrorCode.ToString(), "Error");
                }
                else
                {
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
                }
            }
            axCZKEM1.EnableDevice(iMachineNumber, true);//设置设备状态为开启
            Cursor = Cursors.Default;
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
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Common.DataGridViewStyle.DgvRowPostPaint(this.dgvAttLog, e);
        }
        //添加行号另一个方法
        //private void dgvStudentList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        //{
        //    e.Row.HeaderCell.Value = (e.Row.Index + 1).ToString();
        //}
        #endregion

        #region 记录下载保存的方法
        public void iDateTable()
        {
            //初始化记录变量
            int idwEnrollNumber = 0;
            int idwVerifyMode = 0;
            int idwInOutMode = 0;
            string sTime = "";

            //实例化委托
            objUpdataLbl = new UpdataLbl(LblState);

            //创建一个名为"AttLogTable"的DataTable表
            DataTable AttLogTable = new DataTable();

            //设定列数据
            AttLogTable.Columns.Add("ClockId", typeof(int));
            AttLogTable.Columns.Add("MachineId", typeof(int));
            AttLogTable.Columns.Add("VerifyMode", typeof(int));
            AttLogTable.Columns.Add("InOutMode", typeof(int));
            AttLogTable.Columns.Add("ClockRecord", typeof(DateTime));

            //清空DataTable行数据
            AttLogTable.Rows.Clear();

            //异步修改lbl值
            BeginInvoke(objUpdataLbl, "正在下载记录……");

            while (axCZKEM1.GetGeneralLogDataStr(iMachineNumber, ref idwEnrollNumber, ref idwVerifyMode, ref idwInOutMode, ref sTime))//从内存取得记录
            {
                //把记录循环写入DataTable表
                DataRow dr = AttLogTable.NewRow();
                dr[0] = idwEnrollNumber;
                dr[1] = iMachineNumber;
                dr[2] = idwVerifyMode;
                dr[3] = idwInOutMode;
                dr[4] = sTime;
                AttLogTable.Rows.Add(dr);
            }

            //更新dgvAttLog
            dgvAttLog.DataSource = AttLogTable;

            //异步修改lbl值
            BeginInvoke(objUpdataLbl, "下载完毕！正在筛选记录……");

            #region 数据批量对比去重

            //获取当天日期
            DateTime iToday = DateTime.Today;//当天日期

            //读取数据库已有数据
            DataTable PastLogTable = objAttRecordService.GetAllOriginalLog().Tables[0];

            //求差集结果，
            IEnumerable<DataRow> drResult = AttLogTable.AsEnumerable().Except(PastLogTable.AsEnumerable(), DataRowComparer.Default);

            //处理空结果的异常
            if (drResult.Count() > 0)//如果序列元素的个数>0，则写入数据，否则跳过
            {
                //接收不重复的数据
                DataTable dtResult = drResult.CopyToDataTable();                
                //批量写入数据库
                SQLHelper.UpdataByBulk(dtResult, "OriginalLog");
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
        public static FrmStaffInfo FrmSfManage = null;

        //员工信息菜单事件
        private void 员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmSfManage == null)
            {
                FrmSfManage = new FrmStaffInfo();
                FrmSfManage.Show();
            }
            else
            {
                FrmSfManage.Activate();//激活只能在最小化的时候起作用
                FrmSfManage.WindowState = FormWindowState.Normal;
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
                FrmSfManage.Activate();//激活只能在最小化的时候起作用
                FrmSfManage.WindowState = FormWindowState.Normal;
            }
        }

        //班次管理窗口对象
        public static FrmShiftTimes objFrmClassesTimes = null;

        //班次管理菜单事件
        private void 班次管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmClassesTimes == null)
            {
                objFrmClassesTimes = new FrmShiftTimes();
                objFrmClassesTimes.Show();
            }
            else
            {
                objFrmClassesTimes.Activate();//激活只能在最小化的时候起作用
                objFrmClassesTimes.WindowState = FormWindowState.Normal;
            }
        }

        //时段管理窗口对象
        public static FrmSfWorkTime objFrmTimesManage = null;

        //时段管理菜单事件
        private void 时段管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmTimesManage == null)
            {
                objFrmTimesManage = new FrmSfWorkTime();
                objFrmTimesManage.Show();
            }
            else
            {
                objFrmTimesManage.Activate();
                objFrmTimesManage.WindowState = FormWindowState.Normal;
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
            if (objFrmSignCard==null)
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
    }
}
