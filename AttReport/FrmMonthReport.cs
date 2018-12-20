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

            cboMonthly.Text = DateTime.Today.AddMonths(-1).Month.ToString() + "月";//设置Cbo初始值为上月

        }

        //获取报表

        public void GetMonthReport()
        {
            DateTime BeginDate = DateTime.Parse(cboMonthly.Text.Trim()).AddMonths(-1).Date;//设置起始值为上上月最后1天，根据Cbo值计算

            DateTime EndDate = DateTime.Parse(cboMonthly.Text.Trim()).AddMonths(1).Date;////设置结束值为本月第1天，根据Cbo值计算

            DataTable dtDayRecordTable=objRecordService.GetDayReport(BeginDate, EndDate).Tables[0];//获得月度日报

            //动态筛选(伪代码)
            //dtDayRecordTable.DefaultView.RowFilter = string.Format("WorkTime1>8:00:00");

            //获取员工表

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
