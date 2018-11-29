using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Models;
using DAL;

namespace AttReport
{
    public partial class FrmMonthlyReport : Form
    {
        AttRecordService objRecordService = new AttRecordService();

        public FrmMonthlyReport()
        {
            InitializeComponent();


        }

        //#region 测试代码
        //protected bool getTimeSpan(string timeStr)
        //{
        //    //判断当前时间是否在工作时间段内
        //    string _strWorkingDayAM = "08:30";//工作时间上午08:30
        //    string _strWorkingDayPM = "17:30";
        //    TimeSpan dspWorkingDayAM = DateTime.Parse(_strWorkingDayAM).TimeOfDay;
        //    TimeSpan dspWorkingDayPM = DateTime.Parse(_strWorkingDayPM).TimeOfDay;

        //    //string time1 = "2017-2-17 8:10:00";
        //    DateTime t1 = Convert.ToDateTime(timeStr);

        //    TimeSpan dspNow = t1.TimeOfDay;
        //    if (dspNow > dspWorkingDayAM && dspNow < dspWorkingDayPM)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //#endregion



        //获取报表
        public void GetMonthlyReport()
        {
            //创建新的Datatable表

            //获取原始记录表
            DataTable dtReport = objRecordService.GetMonthlyReportDataSet(dtpStartDate.Text.Trim(), dtpEndDate.Text.Trim()).Tables[0];

            //遍历记录表
            int index=0;

            for (int i = 0; i < dtReport.Rows.Count; i++)
            {
                index++;
                //获得Id
                string iSfId = dtReport.Rows[i]["SfId"].ToString();
                //获得姓名
                string iSfName = objRecordService.GetStaffList(iSfId);
                //获得班次
                string iSfShifts = objRecordService.GetShifts(iSfId);

                if (DateTime.Parse(dtReport.Rows[i]["ClockRecord"].ToString())>= DateTime.Parse("01:00"))
                {

                }
            }


            ////创建一个数据集
            //DataSet ds = new DataSet();
            ////创建一个名为"AttLogTable"的DataTable表
            //DataTable attDt = new DataTable("AttLogTable");

            ////设定列数据
            //attDt.Columns.Add("ClockId", typeof(int));
            //attDt.Columns.Add("MachineId", typeof(int));
            //attDt.Columns.Add("VerifyMode", typeof(int));
            //attDt.Columns.Add("InOutMode", typeof(int));
            //attDt.Columns.Add("ClockRecord", typeof(string));

            ////清空DataTable行数据
            //attDt.Rows.Clear();


            //var Cid= dtReport.Rows[0]["ClockId"].ToString();
            //var idx = dtReport.Select("ClockRecord =Cid");
            //foreach (var item in idx)
            //{
            //    if (item)
            //    {

            //    }
            //}





            DataRow[] drs1 = dtReport.Select("ClockRecord = 'ClockId' ");

            //dgvRecord.Columns.Add(dtReport.Columns[0].ColumnName)

        }


        //窗体关闭事件
        private void FrmMonthlyReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmMonthlyReport = null;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            GetMonthlyReport();
        }
    }
}
