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
    public partial class FrmMonthReport : Form
    {
        AttRecordService objRecordService = new AttRecordService();

        public FrmMonthReport()
        {
            InitializeComponent();

            dtpMonthly.Text = DateTime.Today.AddMonths(-1).Month.ToString() + "月";//设置Cbo初始值为上月

        }

        //获取报表

        public void GetMonthReport()
        {
            DateTime BeginDate = DateTime.Parse(dtpMonthly.Text.Trim()).AddDays(-1).Date;//设置起始值为上上月最后1天，根据Cbo值计算

            DateTime EndDate = DateTime.Parse(dtpMonthly.Text.Trim()).AddMonths(1).Date;////设置结束值为本月第1天，根据Cbo值计算

            DataTable dtDayRecordTable = objRecordService.GetDayReport(BeginDate, EndDate).Tables[0];//获得月度日报

            //获取员工表
            DataTable dtStaffTable = objRecordService.GetAllStaffsDataSet().Tables[0];

            #region 创建Datatable表存放数据  
                      
            DataTable dtMonthTemp = new DataTable("dtMonthTemp");
            //设定列数据
            dtMonthTemp.Columns.Add("SfId", typeof(int));
            dtMonthTemp.Columns.Add("SfDepartment", typeof(string));
            dtMonthTemp.Columns.Add("StaffName", typeof(string));
            dtMonthTemp.Columns.Add("SfJob", typeof(string));
            dtMonthTemp.Columns.Add("SfShouldAtt", typeof(double));
            dtMonthTemp.Columns.Add("SfLegalHoliday", typeof(double));
            dtMonthTemp.Columns.Add("SfActualAtt", typeof(double));
            dtMonthTemp.Columns.Add("SfLeave", typeof(double));
            dtMonthTemp.Columns.Add("SfRest", typeof(double));
            dtMonthTemp.Columns.Add("SfFuneral", typeof(double));
            dtMonthTemp.Columns.Add("SfAnnual", typeof(double));
            dtMonthTemp.Columns.Add("SfAbsenteeism", typeof(double));//旷工
            dtMonthTemp.Columns.Add("SfAccidents", typeof(double));
            dtMonthTemp.Columns.Add("SfFullAtt", typeof(double));
            dtMonthTemp.Columns.Add("SfSeniorityAward", typeof(double));
            dtMonthTemp.Columns.Add("SfSubsidy", typeof(double));
            dtMonthTemp.Columns.Add("SfSleepover", typeof(double));
            dtMonthTemp.Columns.Add("SfOutpatient", typeof(double));
            dtMonthTemp.Columns.Add("SfRetirementInsurance", typeof(double));
            dtMonthTemp.Columns.Add("SfHousingFund", typeof(double));
            dtMonthTemp.Columns.Add("SfOvertime1", typeof(double));
            dtMonthTemp.Columns.Add("SfOvertime2", typeof(double));
            dtMonthTemp.Columns.Add("SfOvertime3", typeof(double));
            dtMonthTemp.Columns.Add("SfReward", typeof(double));
            dtMonthTemp.Columns.Add("SfUtilities", typeof(double));
            dtMonthTemp.Columns.Add("SfOther", typeof(double));
            dtMonthTemp.Columns.Add("SfEntryDate", typeof(double));
            dtMonthTemp.Columns.Add("SfSalaryMethod", typeof(double));
            dtMonthTemp.Columns.Add("SfRemarks", typeof(double));
            dtMonthTemp.Columns.Add("SfAutograph", typeof(double));
            dtMonthTemp.Columns.Add("SfLnsurance", typeof(double));

            #endregion

            //根据员工表计算月报
            if (dtDayRecordTable != null && dtStaffTable != null)
            {
                for (int s = 0; s < dtStaffTable.Rows.Count; s++)
                {
                    int iSfId = Convert.ToInt32(dtStaffTable.Rows[s]["SfId"]);//员工Id
                    string iSfName = dtStaffTable.Rows[s]["SfName"].ToString();//员工姓名
                    string iSfGroupName = dtStaffTable.Rows[s]["SfGroup"].ToString();//员工组别
                    int MonthCount = DateTime.DaysInMonth(dtpMonthly.Value.Year,dtpMonthly.Value.Month);//月天数

                    //获取单个员工的月考勤集合
                    var SfDayResult = (from SfLog in dtDayRecordTable.AsEnumerable()
                                       where Convert.ToInt32(SfLog.Field<Int32>("SfId"))==iSfId
                                       select SfLog).ToList();

                    double SfDay = 0;//员工考勤天数                    

                    for (int m = 0; m < SfDayResult.Count; m++)
                    {
                        SfDay += Convert.ToInt32(SfDayResult[m]["AtDay"]);
                    }

                    DataRow dr = dtMonthTemp.NewRow();
                    dr[0] = iSfId;
                    dr[1] = iSfGroupName;
                    dr[2] = iSfName;
                    dr[3] = null;
                    dr[4] = MonthCount;
                    dr[5] = 0.0;
                    dr[6] = SfDay;
                    dtMonthTemp.Rows.Add(dr);
                }
                //更新DGV
                dgvRecord.DataSource = dtMonthTemp;
            }


            //计算员工考勤天数

            //


            //根据日报计算月报

        }


        //窗体关闭事件
        private void FrmMonthReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmMonthReport = null;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            GetMonthReport();

        }
    }
}
