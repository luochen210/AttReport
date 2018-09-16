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

namespace Common
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

        //声明委托
        public delegate void GetLogDelegate(string getLog);

        //根据委托创建对象
        GetLogDelegate objLogDelegate;

        //public delegate void GetDataTable(DataTable tempTable);

        //GetDataTable objGetDataTable;

        int iGLCount = 0;
        int iIndex = 0;
        int iValue = 0;

        int idwErrorCode = 0;
        int idwEnrollNumber = 0;
        int idwVerifyMode = 0;
        int idwInOutMode = 0;
        string sTime = "";

        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

        #region lblState控件值的修改方法       

        //lblState控件值的修改方法
        public void LblState(string msg)
        {
            lblState.Text = msg;
        }
        #endregion

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

        #region 连接考勤机
        private bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtIP.Text.Trim() == "" || txtPort.Text.Trim() == "")
            {
                MessageBox.Show("IP and Port cannot be null", "Error");
                return;
            }
            int idwErrorCode = 0;

            Cursor = Cursors.WaitCursor;
            if (btnConnect.Text == "DisConnect")
            {
                axCZKEM1.Disconnect();
                bIsConnected = false;
                btnConnect.Text = "Connect";
                lblState.Text = "Current State:DisConnected";
                Cursor = Cursors.Default;
                return;
            }

            bIsConnected = axCZKEM1.Connect_Net(txtIP.Text, Convert.ToInt32(txtPort.Text));
            if (bIsConnected == true)
            {
                btnConnect.Text = "DisConnect";
                btnConnect.Refresh();
                lblState.Text = "Current State:Connected";
                iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Unable to connect the device,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            lblState.Text = "连接成功！等待下载……";
            Cursor = Cursors.Default;
        }
        #endregion

        #region 下载并保存考勤记录


        //异步执行，保存打卡记录
        private void btnGetLog_Click(object sender, EventArgs e)
        {
            #region 异步代码


            //if (bIsConnected == false)
            //{
            //    MessageBox.Show("Please connect the device first", "Error");
            //    return;
            //}

            //Thread objThread = new Thread(new ThreadStart(delegate
            //{
            //    GetAttLog();
            //}));
            //objThread.Start();

            ////实例委托对象
            //objLogDelegate = LblState;
            ////objGetDataTable = iDateTable;
            #endregion

            //判断设备是否为连接状态
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first", "Error");
                return;
            }

            //重置记数变量
            iGLCount = 0;
            iIndex = 0;
            //设置鼠标状态
            Cursor = Cursors.WaitCursor;
            //清除dataGridView控件内容
            dgvAttLog.Rows.Clear();

            //实例委托对象
            objLogDelegate = LblState;

            axCZKEM1.EnableDevice(iMachineNumber, false);//开启设备
            axCZKEM1.GetDeviceStatus(iMachineNumber, 6, ref iValue);//返回记录数量
            this.BeginInvoke(objLogDelegate, "打卡记录数量： " + iValue + "条！正在下载中……");

            if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//将记录读入内存
            {
                //循环取出记录，然后逐条写入DataTable表
                while (axCZKEM1.GetGeneralLogDataStr(iMachineNumber, ref idwEnrollNumber, ref idwVerifyMode, ref idwInOutMode, ref sTime))//从内存中获取记录
                {
                    iGLCount++;
                    dgvAttLog.Rows.Add();
                    dgvAttLog.Rows[iIndex].Cells[0].Value = iGLCount;
                    dgvAttLog.Rows[iIndex].Cells[1].Value = iMachineNumber;
                    dgvAttLog.Rows[iIndex].Cells[2].Value = idwEnrollNumber;
                    dgvAttLog.Rows[iIndex].Cells[3].Value = idwVerifyMode;
                    dgvAttLog.Rows[iIndex].Cells[4].Value = idwInOutMode;
                    dgvAttLog.Rows[iIndex].Cells[5].Value = sTime;
                    iIndex++;
                }
                //记录下载完毕后输出LblState控件提示
                this.BeginInvoke(objLogDelegate, "下载完毕！正在保存……");

                ////批量保存到数据库
                //SQLHelper.UpdataByBulk(dt, "OriginalLog");//dt代表DataTable表，OriginalLog代表SQL数据库表
                //if (dgvAttLog.Rows != null)
                //{
                //    foreach (DataGridViewRow row in dgvAttLog.Rows)
                //    {
                //        objAttRecord.MachineId = Convert.ToInt32(row.Cells[1].Value);
                //        objAttRecord.ClockId = Convert.ToInt32(row.Cells[2].Value);
                //        objAttRecord.VerifyMode = Convert.ToInt32(row.Cells[3].Value);
                //        objAttRecord.InOutMode = Convert.ToInt32(row.Cells[4].Value);
                //        objAttRecord.ClockRecord = row.Cells[5].Value.ToString();
                //    }
                //}

                //修改LblState控件
                this.BeginInvoke(objLogDelegate, "保存完毕！请查询报表！");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);

                if (idwErrorCode != 0)
                {
                    MessageBox.Show("Reading data from terminal failed,ErrorCode: " + idwErrorCode.ToString(), "Error");
                    return;
                }
                else
                {
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
                    return;
                }
            }
            axCZKEM1.EnableDevice(iMachineNumber, true);//关闭设备 
            Cursor = Cursors.Default;
        }
    }
}
        #endregion


            #region 异步代码

            //public void iDateTable(DataTable itempTable)
            //{
            //    //创建一个名为"AttLogTable"的DataTable表
            //    DataTable dt = new DataTable("AttLogTable");

            //    itempTable = dt;

            //    //设定列数据
            //    itempTable.Columns.Add("MachineId", typeof(int));
            //    itempTable.Columns.Add("ClockId", typeof(int));
            //    itempTable.Columns.Add("VerifyMode", typeof(int));
            //    itempTable.Columns.Add("InOutMode", typeof(int));
            //    itempTable.Columns.Add("ClockRecord", typeof(string));

            //    dataGridView1.DataSource = itempTable;

            //}


            //下载记录的方法
            //public void GetAttLog()
            //{
            //    //实例委托对象
            //    objLogDelegate = LblState;
            //    //objGetDataTable = iDateTable;

            //    //判断设备是否为连接状态
            //    if (bIsConnected == false)
            //    {
            //        MessageBox.Show("Please connect the device first", "Error");
            //        return;
            //    }
            //    axCZKEM1.EnableDevice(iMachineNumber, false);//开启设备
            //    axCZKEM1.GetDeviceStatus(iMachineNumber, 6, ref iValue);//返回记录数量
            //    this.BeginInvoke(objLogDelegate, "打卡记录数量： " + iValue + "条！正在下载中……");

            //    DataGridView dgv = new DataGridView();
            //    DataTable dt = new DataTable("AttLogTable");

            //    //设定列数据
            //    dt.Columns.Add("MachineId", typeof(int));
            //    dt.Columns.Add("ClockId", typeof(int));
            //    dt.Columns.Add("VerifyMode", typeof(int));
            //    dt.Columns.Add("InOutMode", typeof(int));
            //    dt.Columns.Add("ClockRecord", typeof(string));

            //    if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//将记录读入内存
            //    {


            //        //循环取出记录，然后逐条写入DataTable表
            //        while (axCZKEM1.GetGeneralLogDataStr(iMachineNumber, ref idwEnrollNumber, ref idwVerifyMode, ref idwInOutMode, ref sTime))//从内存中获取记录
            //        {
            //            iIndex++;
            //            DataRow dr = dt.NewRow();
            //            dr[0] = iMachineNumber;
            //            dr[1] = idwEnrollNumber;
            //            dr[2] = idwVerifyMode;
            //            dr[3] = idwInOutMode;
            //            dr[4] = sTime;
            //            dt.Rows.Add(dr);

            //            dgv.DataSource = dt;
            //        }

            //        //跨线程
            //        //dataGridView1.DataSource = dt;

            //        this.BeginInvoke(objGetDataTable,dt);//为委托表赋值


            //        //修改LblState控件
            //        this.BeginInvoke(objLogDelegate, "下载完毕！正在保存……");

            //        //批量保存到数据库
            //        SQLHelper.UpdataByBulk(dt, "OriginalLog");//dt代表DataTable表，OriginalLog代表SQL数据库表

            //        //修改LblState控件
            //        this.BeginInvoke(objLogDelegate, "保存完毕！请查询报表！");
            //    }
            //    else
            //    {
            //        axCZKEM1.GetLastError(ref idwErrorCode);

            //        if (idwErrorCode != 0)
            //        {
            //            MessageBox.Show("Reading data from terminal failed,ErrorCode: " + idwErrorCode.ToString(), "Error");
            //            return;
            //        }
            //        else
            //        {
            //            axCZKEM1.GetLastError(ref idwErrorCode);
            //            MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            //            return;
            //        }
            //    }
            //    axCZKEM1.EnableDevice(iMachineNumber, true);//关闭设备            
            //}

            #endregion
