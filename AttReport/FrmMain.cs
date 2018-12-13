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
                //异步修改lbl值
                BeginInvoke(objUpdataLbl, "筛选完毕！正在计算报表……");
                //计算日报
                CreateDayLog(dtResult);
                //异步修改lbl值
                BeginInvoke(objUpdataLbl, "计算完毕！正在保存报表……");

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

        //测试事件
        private void btnTest_Click(object sender, EventArgs e)
        {
            //获得测试表

            DataTable dtTest = objAttRecordService.GetAllOriginalLog().Tables[0];

            //测试功能
            CreateDayLog(dtTest);
        }

        #region 日报表计算方法

        //根据读取的记录生成日报表(异步委托)
        public void CreateDayLog(DataTable dtAttLog)
        {
            //实例化委托
            objUpdataLbl = new UpdataLbl(LblState);

            //时段
            TimeSpan psAm = TimeSpan.Parse("00:00:00");//1天开始
            TimeSpan psPm = TimeSpan.Parse("23:59:59");//1天结束

            DateTime iToday = DateTime.Parse("2018/12/10").Date;//测试用,时间为次日9点，修正夜班下班时间

            //获取员工表
            DataTable dtStaff = objAttRecordService.GetAllStaffsDataSet().Tables[0];
            //获取所有时段
            var iTimesList = objAttRecordService.GetAllTimesList();

            //月天数变量
            //DateTime idayNumber; //= DateTime.Now.Date;//日期的天数,测试变量，实际使用中为查询的日期

            #region 创建一个Datatable表存放整理好的打卡数据

            //缓存表,用于存放整理好的打卡数据
            DataTable dtAttTemp = new DataTable("dtAttTemp");
            //设定列数据
            dtAttTemp.Columns.Add("SfId", typeof(int));
            dtAttTemp.Columns.Add("SfName", typeof(string));
            dtAttTemp.Columns.Add("SfGroup", typeof(string));
            dtAttTemp.Columns.Add("SfShifts", typeof(string));
            dtAttTemp.Columns.Add("WorkTime1", typeof(string));
            dtAttTemp.Columns.Add("OffDutyTime1", typeof(string));
            dtAttTemp.Columns.Add("WorkTime2", typeof(string));
            dtAttTemp.Columns.Add("OffDutyTime2", typeof(string));
            dtAttTemp.Columns.Add("WorkTime3", typeof(string));
            dtAttTemp.Columns.Add("OffDutyTime3", typeof(string));
            dtAttTemp.Columns.Add("AtDay", typeof(double));//考勤天数
            dtAttTemp.Columns.Add("AtState", typeof(int));//考勤状态
            dtAttTemp.Columns.Add("AtSign", typeof(int));//处理标记

            #endregion

            #region 计算统计日报
            
            //计算日报
            for (int i = 0; i < dtStaff.Rows.Count; i++)
            {
                double AtDay = 0;//工作天数
                int AtState = 0;//考勤状态 考勤状态 0:正常，1:迟到，2:早退，3:未打卡，4:缺勤，5:无薪请假，6:底薪休假，7:全薪休假
                int AtSign = 0;//考勤处理标记 0:未处理，1:已计算，2:已签卡，3:已处理假期
                int iSfId = Convert.ToInt32(dtStaff.Rows[i]["SfId"]);//员工Id
                string iSfName = dtStaff.Rows[i]["SfName"].ToString();//员工姓名
                string iSfGroupName = dtStaff.Rows[i]["SfGroup"].ToString();//员工组别
                string iClassesName = dtStaff.Rows[i]["SfShifts"].ToString();//班次名称
                var iTimesNameList = objAttRecordService.GetTimesName(iClassesName);//时段名称List

                if (iTimesNameList.Count != 0)
                {
                    string iTimesName1 = iTimesNameList[0].TimesName1;//时段1名称
                    string iTimesName2 = iTimesNameList[0].TimesName2;//时段2名称
                    string iTimesName3 = iTimesNameList[0].TimesName3;//时段3名称

                    //异步修改lbl值
                    BeginInvoke(objUpdataLbl, "开始计算上下班时间……");

                    #region 上下班时间

                    //根据员工分配的班次时段名称获取上下班时间，处理null异常
                    TimeSpan WorkTime1 = TimeSpan.Zero;//上班时间1
                    TimeSpan OffDutyTime1 = TimeSpan.Zero;//下班时间1
                    if (iTimesName1 != "")
                    {
                        //上班时间1
                        WorkTime1 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName1).ToList()[0].WorkTime);
                        //下班时间1
                        OffDutyTime1 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName1).ToList()[0].OffDutyTime);
                    }

                    TimeSpan WorkTime2 = TimeSpan.Zero;//上班时间2
                    TimeSpan OffDutyTime2 = TimeSpan.Zero;//下班时间2
                    if (iTimesName2 != "")
                    {
                        //上班时间2
                        WorkTime2 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName2).ToList()[0].WorkTime);
                        //下班时间2
                        OffDutyTime2 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName2).ToList()[0].OffDutyTime);
                    }

                    TimeSpan WorkTime3 = TimeSpan.Zero;//上班时间3
                    TimeSpan OffDutyTime3 = TimeSpan.Zero;//下班时间3
                    if (iTimesName3 != "")
                    {
                        //上班时间3
                        WorkTime3 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName3).ToList()[0].WorkTime);
                        //下班时间3
                        OffDutyTime3 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName3).ToList()[0].OffDutyTime);
                    }

                    #endregion

                    #region 开始与结束签到时间

                    //////////////////////////////////////////////////开始与结束签到时间/////////////////////////////////////////////////////////

                    TimeSpan StartCheckIn1 = TimeSpan.Zero;//开始签到时间1
                    TimeSpan EndCheckIn1 = TimeSpan.Zero;//结束签到时间1
                    if (iTimesName1 != "")
                    {
                        //开始签到时间1
                        StartCheckIn1 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName1).ToList()[0].StartCheckIn);
                        //结束签到时间1
                        EndCheckIn1 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName1).ToList()[0].EndCheckIn);
                    }

                    TimeSpan StartCheckIn2 = TimeSpan.Zero;//开始签到时间2
                    TimeSpan EndCheckIn2 = TimeSpan.Zero;//结束签到时间2
                    if (iTimesName2 != "")
                    {
                        //开始签到时间2
                        StartCheckIn2 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName2).ToList()[0].StartCheckIn);
                        //结束签到时间2
                        EndCheckIn2 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName2).ToList()[0].EndCheckIn);
                    }

                    TimeSpan StartCheckIn3 = TimeSpan.Zero;//开始签到时间3
                    TimeSpan EndCheckIn3 = TimeSpan.Zero;//结束签到时间3
                    if (iTimesName3 != "")
                    {
                        //开始签到时间3
                        StartCheckIn3 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName3).ToList()[0].StartCheckIn);
                        //结束签到时间3
                        EndCheckIn3 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName3).ToList()[0].EndCheckIn);
                    }

                    #endregion

                    #region 开始与结束签退时间

                    ///////////////////////////////////////////////开始与结束签退时间/////////////////////////////////////////////////

                    TimeSpan StartSignBack1 = TimeSpan.Zero;//开始签退时间1
                    TimeSpan EndSignBack1 = TimeSpan.Zero;//结束签退时间1
                    if (iTimesName1 != "")
                    {
                        //开始签退时间1
                        StartSignBack1 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName1).ToList()[0].StartSignBack);
                        //结束签退时间1
                        EndSignBack1 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName1).ToList()[0].EndSignBack);
                    }

                    TimeSpan StartSignBack2 = TimeSpan.Zero;//开始签退时间2
                    TimeSpan EndSignBack2 = TimeSpan.Zero;//结束签退时间2
                    if (iTimesName2 != "")
                    {
                        //开始签退时间2
                        StartSignBack2 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName2).ToList()[0].StartSignBack);
                        //结束签退时间2
                        EndSignBack2 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName2).ToList()[0].EndSignBack);
                    }

                    TimeSpan StartSignBack3 = TimeSpan.Zero;//开始签退时间3
                    TimeSpan EndSignBack3 = TimeSpan.Zero;//结束签退时间3
                    if (iTimesName3 != "")
                    {
                        //开始签退时间3
                        StartSignBack3 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName3).ToList()[0].StartSignBack);
                        //结束签退时间3
                        EndSignBack3 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName3).ToList()[0].EndSignBack);
                    }
                    ///////////////////////////////////////////////////////////////////////////////////
                    #endregion

                    #region 重新整理打卡记录，根据Id取单日记录                    
                    //异步修改lbl值
                    BeginInvoke(objUpdataLbl, "开始筛选单日记录……");
                    //计算统计每位员工的考勤记录
                    var AttResult = (from log in dtAttLog.AsEnumerable()//查询集合
                                     where Convert.ToInt32(log.Field<Int32>("ClockId")) == iSfId//满足id条件
                                     && Convert.ToDateTime(log.Field<string>("ClockRecord")) < (iToday+StartCheckIn1).AddDays(1)//满足单日条件,修正时间至次日开始签到
                                     select log.Field<string>("ClockRecord")).ToList();//返回记录集合
                    #endregion

                    #region 获取唯一打卡值                     
                    //异步修改lbl值
                    BeginInvoke(objUpdataLbl, "整理完毕！开始归类打卡时间……");
                    /////////////////////
                    //创建局部变量接收唯一打卡值
                    string OnlyWorkTime1 = "";//上班唯一打卡值1
                    string OnlyOffDutyTime1 = "";//下班唯一打卡值1
                    string OnlyWorkTime2 = "";//上班唯一打卡值2
                    string OnlyOffDutyTime2 = "";//下班唯一打卡值2
                    string OnlyWorkTime3 = "";//上班唯一打卡值3
                    string OnlyOffDutyTime3 = "";//下班唯一打卡值3
                    ////////////////////////////////////////////

                    //上班打卡1---大于等于开始签到时间，小于下班开始签退时间，包含迟到（取第一）
                    OnlyWorkTime1 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= StartCheckIn1
                    && DateTime.Parse(at).TimeOfDay < StartSignBack1).FirstOrDefault();
                    //下班打卡1---大于第一次上班结束签到时间，小于第二次上班开始签到时间，包含早退（取最后）
                    OnlyOffDutyTime1 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay > EndCheckIn1
                    && DateTime.Parse(at).TimeOfDay < StartCheckIn2).LastOrDefault();

                    //第二次上班
                    if (WorkTime2 != TimeSpan.Zero && OffDutyTime2 != TimeSpan.Zero)
                    {
                        //上班打卡2
                        OnlyWorkTime2 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= StartCheckIn2
                        && DateTime.Parse(at).TimeOfDay < StartSignBack2).FirstOrDefault();
                        //下班打卡2
                        OnlyOffDutyTime2 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay > EndCheckIn2
                        && DateTime.Parse(at).TimeOfDay < StartCheckIn3).LastOrDefault();

                        //处理延迟下午下班加班的异常
                        if (iClassesName == "办公职员" && OnlyOffDutyTime2.Length == 0)//待修改完善的代码
                        {
                            //获取下班时间后的打卡记录
                            var OffDutyList = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= OffDutyTime2
                            && DateTime.Parse(at).TimeOfDay < psPm).ToList();//psPm=23:59:59

                            //获取最后的打卡记录
                            if (OffDutyList.Count != 0)
                            {
                                //自动签卡，签下班时间
                                OnlyOffDutyTime2 = DateTime.Parse((iToday + OffDutyTime2).ToString())
                                    .AddMinutes(3).AddSeconds(33).ToString(); //为下班时间加33分33秒
                            }
                        }
                    }

                    //第三次上班
                    if (WorkTime3 != TimeSpan.Zero && OffDutyTime3 != TimeSpan.Zero)
                    {
                        //上班打卡3（加班），取大于晚上加班的第一个打卡记录
                        OnlyWorkTime3 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= StartCheckIn3
                        && DateTime.Parse(at).TimeOfDay < psPm).FirstOrDefault();//psPm=23:59:59

                        //下班打卡3（加班），取晚上加班的最后一个打卡记录
                        OnlyOffDutyTime3 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= StartCheckIn3
                        && DateTime.Parse(at) < DateTime.Parse(iToday + StartCheckIn1.ToString()).AddDays(1)).LastOrDefault();//次日上班开始签到时间
                    }

                    //处理两班倒和三班倒加班异常
                    if (WorkTime2 == TimeSpan.Zero && OffDutyTime2 == TimeSpan.Zero && WorkTime3 == TimeSpan.Zero && OffDutyTime3 == TimeSpan.Zero)
                    {
                        //获取下班时间后到次日上班开始签到时间的打卡记录
                        var OffDutyList = AttResult.Where(at => DateTime.Parse(at).TimeOfDay > EndCheckIn1
                        && DateTime.Parse(at) < DateTime.Parse((iToday + StartCheckIn1).ToString()).AddDays(1)).ToList();

                        //获取最后的打卡记录
                        if (OffDutyList.Count != 0)
                        {
                            //自动签卡，签下班时间
                            OnlyOffDutyTime1 = DateTime.Parse(OffDutyList.LastOrDefault()).ToString(); //取最后一个打卡记录
                        }
                    }

                    #endregion

                    #region 处理考勤  
                    //异步修改lbl值
                    BeginInvoke(objUpdataLbl, "归类完毕！开始自动处理正班考勤……");
                    /*处理考勤
                     * 
                     * int AtState = 0;//考勤状态 0:正常，1:迟到，2:早退，3:未打卡，4:缺勤(旷工)，5:无薪请假，6:底薪休假，7:全薪休假
                     * int AtSign = 0;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                     * 
                    */

                    #region 处理正班考勤                    
                    //计算正班天数--如果不是多班倒，并且打卡值不为""，则天数增加
                    if (iTimesName2 != "" && iTimesName3 != "")
                    {
                        if (OnlyWorkTime1 != "" && OnlyOffDutyTime1 != "")
                        {
                            AtDay = AtDay + 0.5;
                        }
                        if (OnlyWorkTime2 != "" && OnlyOffDutyTime2 != "")
                        {
                            AtDay = AtDay + 0.5;
                        }

                        //处理未打卡
                        if (OnlyWorkTime1 == "" || OnlyOffDutyTime1 == "" || OnlyWorkTime2 == "" || OnlyOffDutyTime2 == ""
                            || OnlyWorkTime3 == "" || OnlyOffDutyTime3 == "")
                        {
                            AtState = 3;
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                        //处理迟到
                        if (DateTime.Parse(OnlyWorkTime1).TimeOfDay > WorkTime1 || DateTime.Parse(OnlyWorkTime2).TimeOfDay > WorkTime2)
                        {
                            AtState = 1;//迟到
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                        //处理早退
                        if (DateTime.Parse(OnlyOffDutyTime1).TimeOfDay > OffDutyTime1 || DateTime.Parse(OnlyOffDutyTime2).TimeOfDay > OffDutyTime2)
                        {
                            AtState = 2;//迟到
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                        //处理缺勤(加班除外)
                        if ((OnlyWorkTime1 == "" && OnlyOffDutyTime1 == "") || (OnlyWorkTime2 == "" && OnlyOffDutyTime2 == ""))
                        {
                            AtState = 4;
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                    }

                    #endregion

                    #region 处理多班倒考勤
                    //异步修改lbl值
                    BeginInvoke(objUpdataLbl, "开始处理多班倒考勤……");
                    //计算多班倒天数--如果是多班倒，并且打卡值不为""，则天数增加
                    if (iTimesName2 == "" && iTimesName3 == "")
                    {
                        if (OnlyWorkTime1 != "" && OnlyOffDutyTime1 != "")
                        {
                            AtDay = AtDay + 1;
                        }

                        /*处理考勤
                         * 
                         * int AtState = 0;//考勤状态 0:正常，1:迟到，2:早退，3:未打卡，4:缺勤(旷工)，5:无薪请假，6:底薪休假，7:全薪休假
                         * int AtSign = 0;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                         * 
                        */

                        //处理未打卡
                        if (OnlyWorkTime1 == "" || OnlyOffDutyTime1 == "")
                        {
                            AtState = 3;
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                        //处理迟到
                        if (DateTime.Parse(OnlyWorkTime1).TimeOfDay > WorkTime1)
                        {
                            AtState = 1;//迟到
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                        //处理早退
                        if (DateTime.Parse(OnlyOffDutyTime1).TimeOfDay > OffDutyTime1)
                        {
                            AtState = 2;//迟到
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                        //处理缺勤(加班除外)
                        if (OnlyWorkTime1 == "" && OnlyOffDutyTime1 == "")
                        {
                            AtState = 4;
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }
                    }
                    //异步修改lbl值
                    BeginInvoke(objUpdataLbl, "考勤处理完毕！开始保存数据……");
                    #endregion

                    #endregion

                    #region 把整理后的数据存入Datatable表

                    //存放数据
                    DataRow dr = dtAttTemp.NewRow();
                    dr[0] = iSfId;
                    dr[1] = iSfName;
                    dr[2] = iSfGroupName;
                    dr[3] = iClassesName;
                    dr[4] = OnlyWorkTime1;
                    dr[5] = OnlyOffDutyTime1;
                    dr[6] = OnlyWorkTime2;
                    dr[7] = OnlyOffDutyTime2;
                    dr[8] = OnlyWorkTime3;
                    dr[9] = OnlyOffDutyTime3;
                    dr[10] = AtDay;//天数
                    dr[11] = AtState;//考勤状态
                    dr[12] = AtSign;//处理标记
                    dtAttTemp.Rows.Add(dr);
                    #endregion

                    //显示到DGV
                    dgvDailyReport.DataSource = dtAttTemp;
                }
            }

            #endregion
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
