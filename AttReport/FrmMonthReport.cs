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

            ////设置月报起始值为上月第1天的0点
            //dtpStartDate.Value = DateTime.Now.AddMonths(-1).Date.AddDays(1 - DateTime.Now.Day);//设置值为上月第1天的0点

            ////设置结束值为上月最后1天的最后1秒
            //dtpEndDate.Value = DateTime.Parse(DateTime.Now.AddDays(1 - DateTime.Now.Day).ToShortDateString()).AddSeconds(-1);//设置值为上月最后1天的最后1秒

            //设置月报起始值为上月第1天的0点
            dtpStartDate.Value = DateTime.Now.AddMonths(-1).Date.AddDays(1 - DateTime.Now.Day - 1);//设置值为上上月最后1天的0点

            //设置结束值为上月最后1天的最后1秒
            dtpEndDate.Value = DateTime.Parse(DateTime.Now.AddDays(1 - DateTime.Now.Day + 1).ToShortDateString()).AddSeconds(-1);//设置值为本月第1天的最后1毫秒

        }

        //获取报表

        public void GetMonthlyReport()
        {

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
