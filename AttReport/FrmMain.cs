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
        GetLogDelegate objgetLogDelegate;

        //int iValue;
        int idwErrorCode = 0;
        int idwEnrollNumber = 0;
        int idwVerifyMode = 0;
        int idwInOutMode = 0;
        string sTime = "";

        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

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


        //保存打卡记录
        private void btnGetLog_Click(object sender, EventArgs e)
        {
            #region 原始代码

            //int iValue = 0;
            //if (bIsConnected == false)
            //{
            //    MessageBox.Show("Please connect the device first", "Error");
            //}

            ////创建一个名为"AttLogTable"的DataTable表
            //DataTable dt = new DataTable("AttLogTable");
            //dt.Columns.Add("MachineId", typeof(int));
            //dt.Columns.Add("ClockId", typeof(int));
            //dt.Columns.Add("VerifyMode", typeof(int));
            //dt.Columns.Add("InOutMode", typeof(int));
            //dt.Columns.Add("ClockRecord", typeof(DateTime));

            //axCZKEM1.EnableDevice(iMachineNumber, false);//开启设备
            //axCZKEM1.GetDeviceStatus(iMachineNumber, 6, ref iValue);//返回记录数量

            ////显示考勤数量
            //this.lblState.Text = "记录数量：" + iValue;

            //if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//将记录读入内存
            //{
            //    //循环取出记录，然后逐条写入DataTable表
            //    while (axCZKEM1.GetGeneralLogDataStr(iMachineNumber, ref idwEnrollNumber, ref idwVerifyMode, ref idwInOutMode, ref sTime))//从内存中获取记录
            //    {
            //        iGLCount++;
            //        lvLogs.Items.Add(iGLCount.ToString());
            //        lvLogs.Items[iIndex].SubItems.Add(idwEnrollNumber.ToString());
            //        lvLogs.Items[iIndex].SubItems.Add(idwVerifyMode.ToString());
            //        lvLogs.Items[iIndex].SubItems.Add(idwInOutMode.ToString());
            //        lvLogs.Items[iIndex].SubItems.Add(sTime);
            //        iIndex++;

            //        DataRow dr = dt.NewRow();
            //        //通过索引为DataTable列赋值
            //        if (objAttRecordService.GetClockRecord(sTime) == null)
            //        {
            //            dr[0] = iMachineNumber;
            //            dr[1] = idwEnrollNumber;
            //            dr[2] = idwVerifyMode;
            //            dr[3] = idwInOutMode;
            //            dr[4] = sTime;
            //            dt.Rows.Add(dr);
            //        }
            //    }
            //    //批量保存到数据库
            //    SQLHelper.UpdataByBulk(dt, "OriginalLog");//dt代表DataTable表，OriginalLog代表SQL数据库表
            //}
            //else
            //{
            //    Cursor = Cursors.Default;
            //    axCZKEM1.GetLastError(ref idwErrorCode);

            //    if (idwErrorCode != 0)
            //    {
            //        MessageBox.Show("Reading data from terminal failed,ErrorCode: " + idwErrorCode.ToString(), "Error");
            //    }
            //    else
            //    {
            //        axCZKEM1.GetLastError(ref idwErrorCode);
            //        MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            //    }
            //}
            //axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
            //Cursor = Cursors.Default;
            #endregion
            int iValue = 0;
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first", "Error");
            }
            axCZKEM1.EnableDevice(iMachineNumber, false);//开启设备
            axCZKEM1.GetDeviceStatus(iMachineNumber, 6, ref iValue);//返回记录数量
            this.lblState.Text = "打卡记录数量： " + iValue + "条！正在下载中……";

            Thread objThread = new Thread(new ThreadStart(delegate
            {
                GetAttLog();
            }));
            objThread.Start();

            //实例委托对象
            objgetLogDelegate = LblState;

            //线程完毕后改变lblState值
            if (rState == false)
            {
                //修改LblState控件
                this.BeginInvoke(objgetLogDelegate, "保存完毕！请查询报表！");
            }



        }

        public void LblState(string msg)
        {
            lblState.Text = msg;
        }

        public void GetAttLog()
        {
            //创建一个名为"AttLogTable"的DataTable表
            DataTable dt = new DataTable("AttLogTable");

            //设定列数据
            dt.Columns.Add("MachineId", typeof(int));
            dt.Columns.Add("ClockId", typeof(int));
            dt.Columns.Add("VerifyMode", typeof(int));
            dt.Columns.Add("InOutMode", typeof(int));
            dt.Columns.Add("ClockRecord", typeof(DateTime));
            DataRow dr = dt.NewRow();

            if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//将记录读入内存
            {
                //循环取出记录，然后逐条写入DataTable表
                while (axCZKEM1.GetGeneralLogDataStr(iMachineNumber, ref idwEnrollNumber, ref idwVerifyMode, ref idwInOutMode, ref sTime))//从内存中获取记录
                {
                    //通过索引为DataTable列赋值
                    if (objAttRecordService.GetClockRecord(sTime) == null)
                    {
                        dr[0] = iMachineNumber;
                        dr[1] = idwEnrollNumber;
                        dr[2] = idwVerifyMode;
                        dr[3] = idwInOutMode;
                        dr[4] = sTime;
                        dt.Rows.Add(dr);
                    }
                    SQLHelper.Conlink(false);
                }
                //批量保存到数据库
                SQLHelper.UpdataByBulk(dt, "OriginalLog");//dt代表DataTable表，OriginalLog代表SQL数据库表

            }
            else
            {
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
            axCZKEM1.EnableDevice(iMachineNumber, true);//关闭设备
            #endregion
        }

        //ListView更新方法
        //public void UpdateUI (int iMachineNumber, int idwEnrollNumber,int idwVerifyMode,int idwInOutMode,string sTime)
        //{
        //    iGLCount++;
        //    lvLogs.Items.Add(iGLCount.ToString());
        //    lvLogs.Items[iIndex].SubItems.Add(idwEnrollNumber.ToString());
        //    lvLogs.Items[iIndex].SubItems.Add(idwVerifyMode.ToString());
        //    lvLogs.Items[iIndex].SubItems.Add(idwInOutMode.ToString());
        //    lvLogs.Items[iIndex].SubItems.Add(sTime);
        //    iIndex++;
        //}


        //下载记录的方法    
    }
}
