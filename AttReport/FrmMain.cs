﻿using System;
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
        
        //int idwErrorCode = 0;

        //声明委托
        public delegate void GetDataTable();
        public delegate void UpdataLbl(string msg);

        //根据委托创建对象
        //GetDataTable objGetDataTable;
        //UpdataLbl objUpdataLbl;

        //private bool bIsConnected = false;//声明一个布尔变量，用于设备连接
        //private int iMachineNumber = 1;//设备的序列号。在连接设备之后，这个值将被改变

        ////实例化API
        //public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

        #region 连接考勤机的事件
        private void btnConnect_Click(object sender, EventArgs e)
        {
        //    if (txtIP.Text.Trim() == "" || txtPort.Text.Trim() == "")
        //    {
        //        MessageBox.Show("IP或端口不能为空！", "Error");
        //        return;
        //    }
        //    int idwErrorCode = 0;

        //    Cursor = Cursors.WaitCursor;
        //    if (btnConnect.Text == "断开")
        //    {
        //        axCZKEM1.Disconnect();
        //        bIsConnected = false;
        //        btnConnect.Text = "Connect";
        //        lblState.Text = "设备状态：等待连接";
        //        Cursor = Cursors.Default;
        //        return;
        //    }

        //    bIsConnected = axCZKEM1.Connect_Net(txtIP.Text, Convert.ToInt32(txtPort.Text));
        //    if (bIsConnected == true)
        //    {
        //        btnConnect.Text = "断开";
        //        btnConnect.Refresh();
        //        lblState.Text = "设备状态：等待连接！";
        //        iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
        //        axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
        //    }
        //    else
        //    {
        //        axCZKEM1.GetLastError(ref idwErrorCode);
        //        MessageBox.Show("无法连接设备，错误代码=" + idwErrorCode.ToString(), "Error");
        //    }
        //    lblState.Text = "设备状态：连接成功！请下载记录……";
        //    Cursor = Cursors.Default;
        }
        #endregion

        #region 保存记录的事件
        private void btnGetLog_Click(object sender, EventArgs e)
        {
        //    if (bIsConnected == false)
        //    {
        //        MessageBox.Show("请连接设备！", "Error");
        //        return;
        //    }

        //    Cursor = Cursors.WaitCursor;

        //    objGetDataTable = iDateTable;

        //    axCZKEM1.EnableDevice(iMachineNumber, false);//设置设备状态为关闭
        //    if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//将记录读入内存
        //    {
        //        //异步取得记录
        //        BeginInvoke(objGetDataTable);

        //    }
        //    else
        //    {
        //        Cursor = Cursors.Default;
        //        axCZKEM1.GetLastError(ref idwErrorCode);

        //        if (idwErrorCode != 0)
        //        {
        //            MessageBox.Show("Reading data from terminal failed,ErrorCode: " + idwErrorCode.ToString(), "Error");
        //        }
        //        else
        //        {
        //            axCZKEM1.GetLastError(ref idwErrorCode);
        //            MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
        //        }
        //    }
        //    axCZKEM1.EnableDevice(iMachineNumber, true);//设置设备状态为开启
        //    Cursor = Cursors.Default;
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
        //public void iDateTable()
        //{
        //    //初始化记录变量
        //    int idwEnrollNumber = 0;
        //    int idwVerifyMode = 0;
        //    int idwInOutMode = 0;
        //    string sTime = "";

        //    //创建一个数据集
        //    DataSet ds = new DataSet();
        //    //创建一个名为"AttLogTable"的DataTable表
        //    DataTable attDt = new DataTable("AttLogTable");

        //    //设定列数据
        //    attDt.Columns.Add("ClockId", typeof(int));
        //    attDt.Columns.Add("MachineId", typeof(int));
        //    attDt.Columns.Add("VerifyMode", typeof(int));
        //    attDt.Columns.Add("InOutMode", typeof(int));
        //    attDt.Columns.Add("ClockRecord", typeof(string));

        //    //清空DataTable行数据
        //    attDt.Rows.Clear();

        //    while (axCZKEM1.GetGeneralLogDataStr(iMachineNumber, ref idwEnrollNumber, ref idwVerifyMode, ref idwInOutMode, ref sTime))//从内存取得记录
        //    {
        //        //把记录循环写入DataTable表
        //        DataRow dr = attDt.NewRow();
        //        dr[0] = idwEnrollNumber;
        //        dr[1] = iMachineNumber;
        //        dr[2] = idwVerifyMode;
        //        dr[3] = idwInOutMode;
        //        dr[4] = sTime;
        //        attDt.Rows.Add(dr);
        //    }

        //    //更新dgvAttLog
        //    dgvAttLog.DataSource = attDt;            

        //    #region 新建两个表，对比数据

        //    ////创建ResultTable表存放差集结果
        //    //DataTable resultDt = new DataTable("ResultTable");

        //    ////读取已有数据
        //    //ds = objAttRecordService.GetALLAttRecord("OriginalLog");
        //    //ds.Tables[0].TableName = "RecordTable";//设置表名称

        //    ////添加进数据集
        //    //ds.Tables.Add(attDt);//添加进数据集
        //    ////ds.Tables.Add(dataDt);
        //    //ds.Tables.Add(resultDt);

        //    //attDt = ds.Tables["AttLogTable"];
        //    //resultDt = ds.Tables["ResultTable"];

        //    #endregion


        //    //批量写入数据库
        //    SQLHelper.UpdataByBulk(attDt, "OriginalLog");

        //    //清空dt对象
        //    attDt=null;

        //    //实例化委托
        //    objUpdataLbl = new UpdataLbl(LblState);

        //    //异步修改lbl值
        //    BeginInvoke(objUpdataLbl,"数据保存成功！");

        //}
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
            if (objFrmClassesTimes==null)
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
            if (objFrmTimesManage==null)
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
            if (objFrmJobs==null)
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
    }
}
