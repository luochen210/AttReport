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

        public static string iStaffName;//员工名字



        //获取报表

        public void GetMonthlyReport()
        {
            int iSfId = 0;
            string iSfName = null;
            double iday = 0;
            bool bWorkTime1 = false;
            DateTime WorkTime1=DateTime.Now;
            bool bOffDutyTime1 = false;
            DateTime OffDutyTime1 = DateTime.Now;
            bool bWorkTime2 = false;
            DateTime WorkTime2 = DateTime.Now;
            bool bOffDutyTime2 = false;
            DateTime OffDutyTime2 = DateTime.Now;
            bool bWorkTime3 = false;
            DateTime WorkTime3 = DateTime.Now;
            bool bOffDutyTime3 = false;
            DateTime OffDutyTime3 = DateTime.Now;
            bool LateTime1 = false;
            bool LeftEarly1 = false;
            bool LateTime2 = false;
            bool LeftEarly2 = false;
            bool LateTime3 = false;
            bool LeftEarly3 = false;

            #region 创建临时数据表


            //写入数据表
            DataTable dtAttLogTemp = new DataTable();

            dtAttLogTemp.Columns.Add("iSfId", typeof(int));
            dtAttLogTemp.Columns.Add("iSfName", typeof(string));

            dtAttLogTemp.Columns.Add("WorkTime1", typeof(DateTime));
            dtAttLogTemp.Columns.Add("LateTime1", typeof(int));//迟到标志，0代表正常，1代表迟到

            dtAttLogTemp.Columns.Add("OffDutyTime1", typeof(DateTime));
            dtAttLogTemp.Columns.Add("LeftEarly1", typeof(int));//早退标志，0代表正常，1代表早退

            dtAttLogTemp.Columns.Add("WorkTime2", typeof(DateTime));
            dtAttLogTemp.Columns.Add("LateTime2", typeof(int));

            dtAttLogTemp.Columns.Add("OffDutyTime2", typeof(DateTime));
            dtAttLogTemp.Columns.Add("LeftEarly2", typeof(int));

            dtAttLogTemp.Columns.Add("WorkTime3", typeof(DateTime));
            dtAttLogTemp.Columns.Add("LateTime3", typeof(int));

            dtAttLogTemp.Columns.Add("OffDutyTime3", typeof(DateTime));
            dtAttLogTemp.Columns.Add("LeftEarly3", typeof(int));

            dtAttLogTemp.Columns.Add("iday", typeof(double));

            #endregion
            string strToday = "2018-1%";//测试用变量
            //获得月度打卡记录
            DataTable dtReportTemp = objRecordService.GetMonthlyReportDataSet(strToday).Tables[0];

            for (int i = 0; i < dtReportTemp.Rows.Count; i++)
            {
                //获取员工Id
                iSfId = Convert.ToInt32(dtReportTemp.Rows[i]["ClockId"]);//员工Id，dtReport是DataTable表

                iSfName = objRecordService.GetStaffName(iSfId);

                //获得轮班班次名称
                string iClassesName = objRecordService.GetClassesName(iSfId);//轮班班次名称

                //获取时段名称List
                var iTimesNameList = objRecordService.GetTimesName(iClassesName);

                //计算上午的打卡记录
                //获取时段List
                var iTimesList1 = objRecordService.GetTimes(iTimesNameList[1].ToString());
                var iTimesList2 = objRecordService.GetTimes(iTimesNameList[2].ToString());
                var iTimesList3 = objRecordService.GetTimes(iTimesNameList[3].ToString());

                //获取日期
                var iDate = Convert.ToDateTime(dtReportTemp.Rows[i]["ClockRecord"].ToString()).Date;

                //获取单日记录
                var iDayReportList = from ilist in dtReportTemp.AsEnumerable()
                                     where Convert.ToInt32(ilist.Field<string>("ClockId")) == iSfId//条件1
                                     &&
                                     Convert.ToDateTime(ilist.Field<string>("ClockRecord")).Date == iDate//条件2
                                     select new
                                     {
                                         ClockId = ilist["ClockId"],
                                         ClockRecord = ilist["ClockRecord"]
                                     };                


                //判断打卡时间
                foreach (var item in iDayReportList)
                {
                    if (Convert.ToDateTime(item.ClockRecord).TimeOfDay <= DateTime.Parse(iTimesList1[0].WorkTime).TimeOfDay//如果小于等于上班时间
                        && Convert.ToDateTime(item.ClockRecord).TimeOfDay >= DateTime.Parse(iTimesList1[0].StartCheckIn).TimeOfDay)//如果大于等于开始签到时间
                    {
                        bWorkTime1 = true;
                        WorkTime1 = Convert.ToDateTime(item.ClockRecord);
                    }
                    if (Convert.ToDateTime(item.ClockRecord).TimeOfDay >= DateTime.Parse(iTimesList1[0].OffDutyTime).TimeOfDay//如果小于等于上班时间
                        && Convert.ToDateTime(item.ClockRecord).TimeOfDay <= DateTime.Parse(iTimesList1[0].EndSignBack).TimeOfDay)//如果大于等于开始签到时间
                    {
                        bOffDutyTime1 = true;
                        OffDutyTime1 = Convert.ToDateTime(item.ClockRecord);
                    }
                    if (Convert.ToDateTime(item.ClockRecord).TimeOfDay <= DateTime.Parse(iTimesList2[0].WorkTime).TimeOfDay//如果小于等于上班时间
                        && Convert.ToDateTime(item.ClockRecord).TimeOfDay >= DateTime.Parse(iTimesList2[0].StartCheckIn).TimeOfDay)
                    {
                        bWorkTime2 = true;
                        WorkTime2 = Convert.ToDateTime(item.ClockRecord);
                    }
                    if (Convert.ToDateTime(item.ClockRecord).TimeOfDay >= DateTime.Parse(iTimesList2[0].OffDutyTime).TimeOfDay//如果小于等于上班时间
                        && Convert.ToDateTime(item.ClockRecord).TimeOfDay <= DateTime.Parse(iTimesList2[0].EndSignBack).TimeOfDay)//如果大于等于开始签到时间
                    {
                        bOffDutyTime2 = true;
                        OffDutyTime2 = Convert.ToDateTime(item.ClockRecord);
                    }
                    if (Convert.ToDateTime(item.ClockRecord).TimeOfDay <= DateTime.Parse(iTimesList2[0].WorkTime).TimeOfDay//如果小于等于上班时间
                        && Convert.ToDateTime(item.ClockRecord).TimeOfDay >= DateTime.Parse(iTimesList2[0].StartCheckIn).TimeOfDay)
                    {
                        bWorkTime3 = true;
                        WorkTime3 = Convert.ToDateTime(item.ClockRecord);
                    }
                    if (Convert.ToDateTime(item.ClockRecord).TimeOfDay >= DateTime.Parse(iTimesList3[0].OffDutyTime).TimeOfDay//如果小于等于上班时间
                        && Convert.ToDateTime(item.ClockRecord).TimeOfDay <= DateTime.Parse(iTimesList3[0].EndSignBack).TimeOfDay)//如果大于等于开始签到时间
                    {
                        bOffDutyTime3 = true;
                        OffDutyTime3 = Convert.ToDateTime(item.ClockRecord);
                    }

                    if (bWorkTime1 == true && bOffDutyTime1 == true)
                    {
                        iday = iday + 0.5;//天数加半天
                    }
                    if (bWorkTime2 == true && bOffDutyTime2 == true)
                    {
                        iday = iday + 0.5;//天数加半天
                    }
                    if (bWorkTime3 == true && bOffDutyTime3 == true)
                    {
                        iday = iday + 0;//天数加半天
                    }

                    #region 更新表
                    ////////////////////////////////////////////////////////////////////////////////////
                    DataRow dr = dtAttLogTemp.NewRow();
                    dr[0] = iSfId;
                    dr[1] = iSfName;
                    dr[2] = WorkTime1;
                    dr[3] = LateTime1;
                    dr[4] = OffDutyTime1;
                    dr[5] = LeftEarly1;
                    dr[6] = WorkTime2;
                    dr[7] = LateTime2;
                    dr[8] = OffDutyTime2;
                    dr[9] = LeftEarly2;
                    dr[10] = WorkTime3;
                    dr[11] = LateTime3;
                    dr[12] = OffDutyTime3;
                    dr[13] = LeftEarly3;
                    dr[14] = iday;
                    #endregion

                }


            }


            #region 垃圾代码

            //if (dtpStartDate.Text.Trim() != null && dtpEndDate.Text.Trim() != null)
            //{
            //    int index = 0;
            //    DataTable dtReport = null;

            //    foreach (DataRow item in dtReport.Rows)
            //    {
            //        index++;

            //        //获取员工Id
            //        var iSfId = dtReport.Rows[0]["ClockId"].ToString();//员工Id，dtReport是DataTable表

            //        //获得轮班班次名称
            //        string iClassesName = objRecordService.GetClassesName(iSfId);//轮班班次名称

            //        //获取划分的时段List
            //        var iTimesNameList = objRecordService.GetTimesName(iClassesName);

            //        string TimesName1 = iTimesNameList[0].TimesName1;//时段1
            //        string TimesName2 = iTimesNameList[0].TimesName2;//时段2
            //        string TimesName3 = iTimesNameList[0].TimesName3;//时段3

            //        //获取班次时段List集合
            //        var TimesList1 = objRecordService.GetTimes(TimesName1);
            //        var TimesList2 = objRecordService.GetTimes(TimesName2);
            //        var TimesList3 = objRecordService.GetTimes(TimesName3);


            //        //上班时间
            //        TimeSpan WorkTime1 = TimeSpan.Parse(TimesList1[0].WorkTime);//早上上班时间
            //        TimeSpan WorkTime2 = TimeSpan.Parse(TimesList2[0].WorkTime);//下午上班时间
            //        TimeSpan WorkTime3 = TimeSpan.Parse(TimesList3[0].WorkTime);//晚上上班时间

            //        //开始签到时间
            //        TimeSpan StartCheckIn1 = TimeSpan.Parse(TimesList1[0].StartCheckIn);//上午开始签到
            //        TimeSpan StartCheckIn2 = TimeSpan.Parse(TimesList2[0].StartCheckIn);//下午开始签到
            //        TimeSpan StartCheckIn3 = TimeSpan.Parse(TimesList3[0].StartCheckIn);//晚上开始签到

            //        //结束签到时间
            //        TimeSpan EndCheckIn1 = TimeSpan.Parse(TimesList1[0].EndCheckIn);//上午结束签到
            //        TimeSpan EndCheckIn2 = TimeSpan.Parse(TimesList2[0].EndCheckIn);//下午结束签到
            //        TimeSpan EndCheckIn3 = TimeSpan.Parse(TimesList3[0].EndCheckIn);//晚上结束签到

            //        //下班时间
            //        TimeSpan OffDutyTime1 = TimeSpan.Parse(TimesList1[0].OffDutyTime);//上午下班时间
            //        TimeSpan OffDutyTime2 = TimeSpan.Parse(TimesList2[0].OffDutyTime);//下午下班时间
            //        TimeSpan OffDutyTime3 = TimeSpan.Parse(TimesList3[0].OffDutyTime);//晚上下班时间

            //        //获得打卡时间
            //        TimeSpan iClockRecord = TimeSpan.Parse(dtReport.Rows[0]["ClockRecord"].ToString());

            //        if (iClockRecord >= StartCheckIn1 && iClockRecord <= WorkTime1)
            //        {
            //            //记录上午上班时间
            //        }
            //        else if (iClockRecord >= StartCheckIn2 && iClockRecord <= WorkTime2)
            //        {
            //            //记录下午上班时间
            //        }
            //        else if (iClockRecord >= StartCheckIn3 && iClockRecord <= WorkTime3)
            //        {
            //            //记录晚上加班上班时间
            //        }
            //        else if (iClockRecord >= OffDutyTime1 && iClockRecord <= EndCheckIn1)
            //        {
            //            //记录上午下班时间
            //        }
            //        else if (iClockRecord >= OffDutyTime2 && iClockRecord <= EndCheckIn2)
            //        {
            //            //记录下午下班时间
            //        }
            //        else if (iClockRecord >= OffDutyTime3 && iClockRecord <= EndCheckIn3)
            //        {
            //            //记录加班下班时间
            //        }
            //    }
            //}
            #endregion

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
