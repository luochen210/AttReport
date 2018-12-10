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

        #region 记录下载的方法
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
            AttLogTable.Columns.Add("ClockRecord", typeof(string));

            //清空DataTable行数据
            AttLogTable.Rows.Clear();

            ////读取已有数据
            //DataTable PastLogTable = objAttRecordService.GetAllOriginalLog().Tables[0];

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
            BeginInvoke(objUpdataLbl, "下载完毕！正在保存记录……");

            #region 数据批量对比去重

            //读取数据库已有数据
            DataTable PastLogTable = objAttRecordService.GetAllOriginalLog().Tables[0];

            //求差集结果，
            IEnumerable<DataRow> drResult = AttLogTable.AsEnumerable().Except(PastLogTable.AsEnumerable(), DataRowComparer.Default);

            //处理空结果的异常
            if (drResult.Count() > 0)//如果序列元素的个数>0，则写入数据，否则跳过
            {
                DataTable dtResult = drResult.CopyToDataTable();

                //异步修改lbl值
                BeginInvoke(objUpdataLbl, "正在生成日报！");

                //生成日报
                CreateDayLog(dtResult);
                //异步修改lbl值
                BeginInvoke(objUpdataLbl, "日报生成成功！");

                //批量写入数据库
                SQLHelper.UpdataByBulk(dtResult, "OriginalLog");
            }

            #endregion           


            //清空dt对象
            AttLogTable = null;
            PastLogTable = null;

            //异步修改lbl值
            BeginInvoke(objUpdataLbl, "数据保存成功！");

        }
        #endregion


        #region 创建日报表

        //根据读取的记录生成日报表(异步委托)
        public void CreateDayLog(DataTable dtAttLog)
        {
            //var listRssult = dtAttLog.AsEnumerable();

            #region 查询所有员工的日报记录
            
            //获取员工表
            DataTable dtStaff = objAttRecordService.GetAllStaffsDataSet().Tables[0];

            //获取所有时段
            var iTimesList = objAttRecordService.GetAllTimesList();

            //月天数变量
            var idayNumber = DateTime.Now;//日期的天数,测试变量，实际使用中为查询的日期

            DataTable dt = new DataTable();

            //计算日报
            for (int i = 0; i < dtStaff.Rows.Count; i++)
            {
                int iSfId = Convert.ToInt32(dtStaff.Rows[i]["SfId"]);//员工Id
                string iSfName = dtStaff.Rows[i]["SfName"].ToString();//员工姓名
                string iSfGroupName = dtStaff.Rows[i]["SfGroup"].ToString();//员工组别
                string iClassesName = dtStaff.Rows[i]["SfShifts"].ToString();//班次名称

                var iTimesNameList = objAttRecordService.GetTimesName(iClassesName);//时段名称List  

                #region 放弃的代码

                if (iTimesNameList.Count != 0)
                {
                    string iTimesName1 = iTimesNameList[0].TimesName1;//时段1名称
                    string iTimesName2 = iTimesNameList[0].TimesName2;//时段2名称
                    string iTimesName3 = iTimesNameList[0].TimesName3;//时段3名称


                    //LinQ多表查询，获取某个员工当天的打卡记录
                    var Result1 = from log in dtAttLog.AsEnumerable()
                                  where Convert.ToInt32(log.Field<Int32>("ClockId")) == iSfId
                                  &&
                                  DateTime.Parse(log.Field<string>("ClockRecord").ToString()).TimeOfDay//查找打卡时间
                                  <= TimeSpan.Parse(iTimesList.Find(times => times.TimesName.Equals(iTimesName1)).WorkTime.ToString())//查找时段list的第一次上班时间
                                  &&
                                  DateTime.Parse(log.Field<string>("ClockRecord")).Day == idayNumber.Day//天数相等
                                  select new
                                  {
                                      iSfId,
                                      iSfName,
                                      iSfGroupName,
                                      ClockRecord = log.Field<string>("ClockRecord")
                                  };

                    //添加进表
                    foreach (var item in Result1)
                    {
                        DataRow dr = dt.NewRow();
                        dr[0] = item.iSfId;
                        dr[1] = item.iSfName;
                        dr[2] = item.iSfGroupName;
                        dr[3] = item.ClockRecord;
                        dt.Rows.Add(dr);
                    }
                }
                #endregion
            }

            #endregion

            //     int sfId = datatable.rows[i][sfId]；
            //     string name =…
            //     string date =…
            //     var days = form p in datatable1.AsEnumerable()
            //where p.field〈string〉（“打卡记录”）
            //〈上班时间，&& 〉签到时间
            //     select p.field<string>("记录").tolist()

        }



        #endregion


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
        }

        //员工信息窗口对象
        public static FrmSfManage objFrmCorporate = null;

        //员工信息菜单事件
        private void 员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmCorporate == null)
            {
                objFrmCorporate = new FrmSfManage();
                objFrmCorporate.Show();
            }
            else
            {
                objFrmCorporate.Activate();//激活只能在最小化的时候起作用
                objFrmCorporate.WindowState = FormWindowState.Normal;
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
                objFrmCorporate.Activate();//激活只能在最小化的时候起作用
                objFrmCorporate.WindowState = FormWindowState.Normal;
            }
        }

        //班次管理窗口对象
        public static FrmClassesTimes objFrmClassesTimes = null;

        //班次管理菜单事件
        private void 班次管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmClassesTimes == null)
            {
                objFrmClassesTimes = new FrmClassesTimes();
                objFrmClassesTimes.Show();
            }
            else
            {
                objFrmClassesTimes.Activate();//激活只能在最小化的时候起作用
                objFrmClassesTimes.WindowState = FormWindowState.Normal;
            }
        }

        //时段管理窗口对象
        public static FrmTimesManage objFrmTimesManage = null;

        //时段管理菜单事件
        private void 时段管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmTimesManage == null)
            {
                objFrmTimesManage = new FrmTimesManage();
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
        public static FrmMonthlyReport objFrmMonthlyReport = null;

        //月报查询菜单事件
        private void 月报查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objFrmMonthlyReport == null)
            {
                objFrmMonthlyReport = new FrmMonthlyReport();
                objFrmMonthlyReport.Show();
            }
            else
            {
                objFrmMonthlyReport.Activate();//激活窗口并给焦点
                objFrmMonthlyReport.WindowState = FormWindowState.Normal;
            }
        }
    }
}
