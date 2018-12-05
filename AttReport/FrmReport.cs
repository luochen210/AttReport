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

        public static string iStaffName = string.Empty;//员工名字



        //获取报表

        public void GetMonthlyReport()
        {
            double iDay = 0;//天

            if (dtpStartDate.Text.Trim() != null && dtpEndDate.Text.Trim() != null)
            {
                int index = 0;
                DataTable dtReport = null;

                foreach (DataRow item in dtReport.Rows)
                {
                    index++;

                    //获取员工Id
                    var iSfId = dtReport.Rows[0]["ClockId"].ToString();//员工Id

                    //获得轮班班次名称
                    string iClassesName = objRecordService.GetClassesName(iSfId);//轮班班次名称

                    //获取划分的时段List
                    var iTimesNameList = objRecordService.GetTimesName(iClassesName);

                    string TimesName1 = iTimesNameList[0].TimesName1;//时段1
                    string TimesName2 = iTimesNameList[0].TimesName2;//时段2
                    string TimesName3 = iTimesNameList[0].TimesName3;//时段3

                    //获取班次时段List集合
                    var TimesList1 = objRecordService.GetTimes(TimesName1);
                    var TimesList2 = objRecordService.GetTimes(TimesName2);
                    var TimesList3 = objRecordService.GetTimes(TimesName3);


                    //上班时间
                    TimeSpan WorkTime1 = TimeSpan.Parse(TimesList1[0].WorkTime);//早上上班时间
                    TimeSpan WorkTime2 = TimeSpan.Parse(TimesList2[0].WorkTime);//下午上班时间
                    TimeSpan WorkTime3 = TimeSpan.Parse(TimesList3[0].WorkTime);//晚上上班时间

                    //开始签到时间
                    TimeSpan StartCheckIn1 = TimeSpan.Parse(TimesList1[0].StartCheckIn);//上午开始签到
                    TimeSpan StartCheckIn2 = TimeSpan.Parse(TimesList2[0].StartCheckIn);//下午开始签到
                    TimeSpan StartCheckIn3 = TimeSpan.Parse(TimesList3[0].StartCheckIn);//晚上开始签到

                    //结束签到时间
                    TimeSpan EndCheckIn1 = TimeSpan.Parse(TimesList1[0].EndCheckIn);//上午结束签到
                    TimeSpan EndCheckIn2 = TimeSpan.Parse(TimesList2[0].EndCheckIn);//下午结束签到
                    TimeSpan EndCheckIn3 = TimeSpan.Parse(TimesList3[0].EndCheckIn);//晚上结束签到

                    //下班时间
                    TimeSpan OffDutyTime1 = TimeSpan.Parse(TimesList1[0].OffDutyTime);//上午下班时间
                    TimeSpan OffDutyTime2 = TimeSpan.Parse(TimesList2[0].OffDutyTime);//下午下班时间
                    TimeSpan OffDutyTime3 = TimeSpan.Parse(TimesList3[0].OffDutyTime);//晚上下班时间

                    //获得打卡时间
                    TimeSpan iClockRecord = TimeSpan.Parse(dtReport.Rows[0]["ClockRecord"].ToString());

                    if (iClockRecord >= StartCheckIn1 && iClockRecord <= WorkTime1)
                    {
                        //记录上午上班时间
                    }
                    else if (iClockRecord >= StartCheckIn2 && iClockRecord <= WorkTime2)
                    {
                        //记录下午上班时间
                    }
                    else if (iClockRecord >= StartCheckIn3 && iClockRecord <= WorkTime3)
                    {
                        //记录晚上加班上班时间
                    }
                    else if (iClockRecord >= OffDutyTime1 && iClockRecord <= EndCheckIn1)
                    {
                        //记录上午下班时间
                    }
                    else if (iClockRecord >= OffDutyTime2 && iClockRecord <= EndCheckIn2)
                    {
                        //记录下午下班时间
                    }
                    else if (iClockRecord >= OffDutyTime3 && iClockRecord <= EndCheckIn3)
                    {
                        //记录加班下班时间
                    }
                }

            }

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
