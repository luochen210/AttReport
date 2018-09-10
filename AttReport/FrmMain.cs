using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modes;
using DAL;

namespace AttReport
{
    public partial class FrmMain : Form
    {
        private AttRecordService objAttRecordService = new AttRecordService();
        public FrmMain()
        {
            InitializeComponent();
        }

        //Create Standalone SDK class dynamicly.
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
            Cursor = Cursors.Default;
        }

        #endregion

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first", "Error");
                return;
            }
            int idwErrorCode = 0;

            int idwEnrollNumber = 0;
            int idwVerifyMode = 0;
            int idwInOutMode = 0;
            string sTime = "";

            int iGLCount = 0;
            int iIndex = 0;

            Cursor = Cursors.WaitCursor;


            AttRecord objAttRecord = new AttRecord();
            objAttRecord = objAttRecordService.GetAttRecord(objAttRecord);

            lvLogs.Items.Clear();
            axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
            if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//read the records to the memory
            {
                while (axCZKEM1.GetGeneralLogDataStr(iMachineNumber, ref idwEnrollNumber, ref idwVerifyMode, ref idwInOutMode, ref sTime))//get the records from memory
                {
                    iGLCount++;
                    lvLogs.Items.Add(iGLCount.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(iMachineNumber.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(idwEnrollNumber.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(idwVerifyMode.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(idwInOutMode.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(sTime);
                    iIndex++;

                    //获取对象值

                    objAttRecordService.GetAttRecord(iMachineNumber, idwEnrollNumber, idwVerifyMode, idwInOutMode, sTime);

                    if (true)
                    {

                    }


                    objAttRecordService.AddAttRecord(iMachineNumber, idwEnrollNumber, idwVerifyMode, idwInOutMode, sTime);

                }
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
            axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
            Cursor = Cursors.Default;
        }
    }
}
