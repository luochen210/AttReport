﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;
using Models;

namespace AttReport
{
    public partial class FrmDayReport : Form
    {
        private AttRecord objAttRecord = new AttRecord();
        private AttRecordService objAttRecordService = new AttRecordService();
        public FrmDayReport()
        {
            InitializeComponent();
        }




        #region 日报表计算方法

        //根据读取的记录生成日报表
        public void CreateDayLog(DateTime iToday, DataTable dtAttLog)
        {

            //时段
            TimeSpan psAm = TimeSpan.Parse("00:00:00");//1天开始
            TimeSpan psPm = TimeSpan.Parse("23:59:59");//1天结束

            //获取当天日期
            //iToday = DateTime.Today;

            //获取员工表
            DataTable dtStaff = objAttRecordService.GetAllStaffsDataSet().Tables[0];
            //获取所有时段
            var iTimesList = objAttRecordService.GetAllTimesList();

            //月天数变量
            //DateTime idayNumber; //= DateTime.Now.Date;//日期的天数,测试变量，实际使用中为查询的日期

            #region 创建一个Datatable表存放整理好的打卡数据

            //缓存表,用于存放整理好的打卡数据
            DataTable dtAttTemp = new DataTable("dtAttTemp");
            //设定列数据
            dtAttTemp.Columns.Add("SfId", typeof(int));
            dtAttTemp.Columns.Add("SfName", typeof(string));
            dtAttTemp.Columns.Add("SfGroup", typeof(string));
            dtAttTemp.Columns.Add("SfShifts", typeof(string));
            dtAttTemp.Columns.Add("WorkTime1", typeof(string));
            dtAttTemp.Columns.Add("OffDutyTime1", typeof(string));
            dtAttTemp.Columns.Add("WorkTime2", typeof(string));
            dtAttTemp.Columns.Add("OffDutyTime2", typeof(string));
            dtAttTemp.Columns.Add("WorkTime3", typeof(string));
            dtAttTemp.Columns.Add("OffDutyTime3", typeof(string));
            dtAttTemp.Columns.Add("AtDay", typeof(double));//考勤天数
            dtAttTemp.Columns.Add("AtState", typeof(int));//考勤状态
            dtAttTemp.Columns.Add("AtSign", typeof(int));//处理标记

            #endregion

            #region 计算统计日报

            //计算日报
            for (int i = 0; i < dtStaff.Rows.Count; i++)
            {
                double AtDay = 0;//工作天数
                int AtState = 0;//考勤状态 考勤状态 0:正常，1:迟到，2:早退，3:未打卡，4:缺勤，5:无薪请假，6:底薪休假，7:全薪休假
                int AtSign = 0;//考勤处理标记 0:未处理，1:已计算，2:已签卡，3:已处理假期
                int iSfId = Convert.ToInt32(dtStaff.Rows[i]["SfId"]);//员工Id
                string iSfName = dtStaff.Rows[i]["SfName"].ToString();//员工姓名
                string iSfGroupName = dtStaff.Rows[i]["SfGroup"].ToString();//员工组别
                string iClassesName = dtStaff.Rows[i]["SfShifts"].ToString();//班次名称
                var iTimesNameList = objAttRecordService.GetTimesName(iClassesName);//时段名称List

                if (iTimesNameList.Count!=0)
                {
                    string iTimesName1 = iTimesNameList[0].TimesName1;//时段1名称
                    string iTimesName2 = iTimesNameList[0].TimesName2;//时段2名称
                    string iTimesName3 = iTimesNameList[0].TimesName3;//时段3名称

                    #region 上下班时间

                    //根据员工分配的班次时段名称获取上下班时间，处理null异常
                    TimeSpan WorkTime1 = TimeSpan.Zero;//上班时间1
                    TimeSpan OffDutyTime1 = TimeSpan.Zero;//下班时间1
                    if (iTimesName1 != "")
                    {
                        //上班时间1
                        WorkTime1 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName1).ToList()[0].WorkTime);
                        //下班时间1
                        OffDutyTime1 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName1).ToList()[0].OffDutyTime);
                    }

                    TimeSpan WorkTime2 = TimeSpan.Zero;//上班时间2
                    TimeSpan OffDutyTime2 = TimeSpan.Zero;//下班时间2
                    if (iTimesName2 != "")
                    {
                        //上班时间2
                        WorkTime2 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName2).ToList()[0].WorkTime);
                        //下班时间2
                        OffDutyTime2 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName2).ToList()[0].OffDutyTime);
                    }

                    TimeSpan WorkTime3 = TimeSpan.Zero;//上班时间3
                    TimeSpan OffDutyTime3 = TimeSpan.Zero;//下班时间3
                    if (iTimesName3 != "")
                    {
                        //上班时间3
                        WorkTime3 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName3).ToList()[0].WorkTime);
                        //下班时间3
                        OffDutyTime3 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName3).ToList()[0].OffDutyTime);
                    }

                    #endregion

                    #region 开始与结束签到时间

                    //////////////////////////////////////////////////开始与结束签到时间/////////////////////////////////////////////////////////

                    TimeSpan StartCheckIn1 = TimeSpan.Zero;//开始签到时间1
                    TimeSpan EndCheckIn1 = TimeSpan.Zero;//结束签到时间1
                    if (iTimesName1 != "")
                    {
                        //开始签到时间1
                        StartCheckIn1 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName1).ToList()[0].StartCheckIn);
                        //结束签到时间1
                        EndCheckIn1 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName1).ToList()[0].EndCheckIn);
                    }

                    TimeSpan StartCheckIn2 = TimeSpan.Zero;//开始签到时间2
                    TimeSpan EndCheckIn2 = TimeSpan.Zero;//结束签到时间2
                    if (iTimesName2 != "")
                    {
                        //开始签到时间2
                        StartCheckIn2 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName2).ToList()[0].StartCheckIn);
                        //结束签到时间2
                        EndCheckIn2 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName2).ToList()[0].EndCheckIn);
                    }

                    TimeSpan StartCheckIn3 = TimeSpan.Zero;//开始签到时间3
                    TimeSpan EndCheckIn3 = TimeSpan.Zero;//结束签到时间3
                    if (iTimesName3 != "")
                    {
                        //开始签到时间3
                        StartCheckIn3 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName3).ToList()[0].StartCheckIn);
                        //结束签到时间3
                        EndCheckIn3 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName3).ToList()[0].EndCheckIn);
                    }

                    #endregion

                    #region 开始与结束签退时间

                    ///////////////////////////////////////////////开始与结束签退时间/////////////////////////////////////////////////

                    TimeSpan StartSignBack1 = TimeSpan.Zero;//开始签退时间1
                    TimeSpan EndSignBack1 = TimeSpan.Zero;//结束签退时间1
                    if (iTimesName1 != "")
                    {
                        //开始签退时间1
                        StartSignBack1 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName1).ToList()[0].StartSignBack);
                        //结束签退时间1
                        EndSignBack1 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName1).ToList()[0].EndSignBack);
                    }

                    TimeSpan StartSignBack2 = TimeSpan.Zero;//开始签退时间2
                    TimeSpan EndSignBack2 = TimeSpan.Zero;//结束签退时间2
                    if (iTimesName2 != "")
                    {
                        //开始签退时间2
                        StartSignBack2 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName2).ToList()[0].StartSignBack);
                        //结束签退时间2
                        EndSignBack2 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName2).ToList()[0].EndSignBack);
                    }

                    TimeSpan StartSignBack3 = TimeSpan.Zero;//开始签退时间3
                    TimeSpan EndSignBack3 = TimeSpan.Zero;//结束签退时间3
                    if (iTimesName3 != "")
                    {
                        //开始签退时间3
                        StartSignBack3 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName3).ToList()[0].StartSignBack);
                        //结束签退时间3
                        EndSignBack3 = TimeSpan.Parse(iTimesList
                            .Where(time => time.TimesName == iTimesName3).ToList()[0].EndSignBack);
                    }
                    ///////////////////////////////////////////////////////////////////////////////////
                    #endregion

                    #region 重新整理打卡记录，根据Id取单日记录                    

                    //计算统计每位员工的考勤记录
                    var AttResult = (from log in dtAttLog.AsEnumerable()//查询集合
                                     where Convert.ToInt32(log.Field<Int32>("ClockId")) == iSfId//满足id条件
                                     && Convert.ToDateTime(log.Field<string>("ClockRecord")) < (iToday + StartCheckIn1).AddDays(1)//满足单日条件,修正时间至次日开始签到
                                     select log.Field<string>("ClockRecord")).ToList();//返回记录集合
                    #endregion

                    #region 获取唯一打卡值                     

                    /////////////////////
                    //创建局部变量接收唯一打卡值
                    string OnlyWorkTime1 = "";//上班唯一打卡值1
                    string OnlyOffDutyTime1 = "";//下班唯一打卡值1
                    string OnlyWorkTime2 = "";//上班唯一打卡值2
                    string OnlyOffDutyTime2 = "";//下班唯一打卡值2
                    string OnlyWorkTime3 = "";//上班唯一打卡值3
                    string OnlyOffDutyTime3 = "";//下班唯一打卡值3
                    ////////////////////////////////////////////

                    //上班打卡1---大于等于开始签到时间，小于下班开始签退时间，包含迟到（取第一）
                    OnlyWorkTime1 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= StartCheckIn1
                    && DateTime.Parse(at).TimeOfDay < StartSignBack1).FirstOrDefault();
                    //下班打卡1---大于第一次上班结束签到时间，小于第二次上班开始签到时间，包含早退（取最后）
                    OnlyOffDutyTime1 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay > EndCheckIn1
                    && DateTime.Parse(at).TimeOfDay < StartCheckIn2).LastOrDefault();

                    //第二次上班
                    if (WorkTime2 != TimeSpan.Zero && OffDutyTime2 != TimeSpan.Zero)
                    {
                        //上班打卡2
                        OnlyWorkTime2 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= StartCheckIn2
                        && DateTime.Parse(at).TimeOfDay < StartSignBack2).FirstOrDefault();
                        //下班打卡2
                        OnlyOffDutyTime2 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay > EndCheckIn2
                        && DateTime.Parse(at).TimeOfDay < StartCheckIn3).LastOrDefault();

                        //处理延迟下午下班加班的异常
                        if (iClassesName == "办公职员" && OnlyOffDutyTime2.Length == 0)//待修改完善的代码
                        {
                            //获取下班时间后的打卡记录
                            var OffDutyList = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= OffDutyTime2
                            && DateTime.Parse(at).TimeOfDay < psPm).ToList();//psPm=23:59:59

                            //获取最后的打卡记录
                            if (OffDutyList.Count != 0)
                            {
                                //自动签卡，签下班时间
                                OnlyOffDutyTime2 = DateTime.Parse((iToday + OffDutyTime2).ToString())
                                    .AddMinutes(3).AddSeconds(33).ToString(); //为下班时间加33分33秒
                            }
                        }
                    }

                    //第三次上班
                    if (WorkTime3 != TimeSpan.Zero && OffDutyTime3 != TimeSpan.Zero)
                    {
                        //上班打卡3（加班），取大于晚上加班的第一个打卡记录
                        OnlyWorkTime3 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= StartCheckIn3
                        && DateTime.Parse(at).TimeOfDay < psPm).FirstOrDefault();//psPm=23:59:59

                        //下班打卡3（加班），取晚上加班的最后一个打卡记录
                        OnlyOffDutyTime3 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= StartCheckIn3
                        && DateTime.Parse(at) < DateTime.Parse(iToday + StartCheckIn1.ToString()).AddDays(1)).LastOrDefault();//次日上班开始签到时间
                    }

                    //处理两班倒和三班倒加班异常
                    if (WorkTime2 == TimeSpan.Zero && OffDutyTime2 == TimeSpan.Zero && WorkTime3 == TimeSpan.Zero && OffDutyTime3 == TimeSpan.Zero)
                    {
                        //获取下班时间后到次日上班开始签到时间的打卡记录
                        var OffDutyList = AttResult.Where(at => DateTime.Parse(at).TimeOfDay > EndCheckIn1
                        && DateTime.Parse(at) < DateTime.Parse((iToday + StartCheckIn1).ToString()).AddDays(1)).ToList();

                        //获取最后的打卡记录
                        if (OffDutyList.Count != 0)
                        {
                            //自动签卡，签下班时间
                            OnlyOffDutyTime1 = DateTime.Parse(OffDutyList.LastOrDefault()).ToString(); //取最后一个打卡记录
                        }
                    }

                    #endregion

                    #region 处理考勤

                    /*处理考勤
                     * 
                     * int AtState = 0;//考勤状态 0:正常，1:迟到，2:早退，3:未打卡，4:缺勤(旷工)，5:无薪请假，6:底薪休假，7:全薪休假
                     * int AtSign = 0;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                     * 
                    */

                    #region 处理正班考勤                    
                    //计算正班天数--如果不是多班倒，并且打卡值不为""，则天数增加
                    if (iTimesName2 != "" && iTimesName3 != "")
                    {
                        if (OnlyWorkTime1 != "" && OnlyOffDutyTime1 != "")
                        {
                            AtDay = AtDay + 0.5;
                        }
                        if (OnlyWorkTime2 != "" && OnlyOffDutyTime2 != "")
                        {
                            AtDay = AtDay + 0.5;
                        }

                        //处理未打卡
                        if (OnlyWorkTime1 == "" || OnlyOffDutyTime1 == "" || OnlyWorkTime2 == "" || OnlyOffDutyTime2 == ""
                            || OnlyWorkTime3 == "" || OnlyOffDutyTime3 == "")
                        {
                            AtState = 3;
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                        //处理迟到
                        if (DateTime.Parse(OnlyWorkTime1).TimeOfDay > WorkTime1 || DateTime.Parse(OnlyWorkTime2).TimeOfDay > WorkTime2)
                        {
                            AtState = 1;//迟到
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                        //处理早退
                        if (DateTime.Parse(OnlyOffDutyTime1).TimeOfDay > OffDutyTime1 || DateTime.Parse(OnlyOffDutyTime2).TimeOfDay > OffDutyTime2)
                        {
                            AtState = 2;//迟到
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                        //处理缺勤(加班除外)
                        if ((OnlyWorkTime1 == "" && OnlyOffDutyTime1 == "") || (OnlyWorkTime2 == "" && OnlyOffDutyTime2 == ""))
                        {
                            AtState = 4;
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                    }

                    #endregion

                    #region 处理多班倒考勤

                    //计算多班倒天数--如果是多班倒，并且打卡值不为""，则天数增加
                    if (iTimesName2 == "" && iTimesName3 == "")
                    {
                        if (OnlyWorkTime1 != "" && OnlyOffDutyTime1 != "")
                        {
                            AtDay = AtDay + 1;
                        }

                        /*处理考勤
                         * 
                         * int AtState = 0;//考勤状态 0:正常，1:迟到，2:早退，3:未打卡，4:缺勤(旷工)，5:无薪请假，6:底薪休假，7:全薪休假
                         * int AtSign = 0;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                         * 
                        */

                        //处理未打卡
                        if (OnlyWorkTime1 == "" || OnlyOffDutyTime1 == "")
                        {
                            AtState = 3;
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                        //处理迟到
                        if (DateTime.Parse(OnlyWorkTime1).TimeOfDay > WorkTime1)
                        {
                            AtState = 1;//迟到
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                        //处理早退
                        if (DateTime.Parse(OnlyOffDutyTime1).TimeOfDay > OffDutyTime1)
                        {
                            AtState = 2;//迟到
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }

                        //处理缺勤(加班除外)
                        if (OnlyWorkTime1 == "" && OnlyOffDutyTime1 == "")
                        {
                            AtState = 4;
                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
                        }
                    }

                    #endregion

                    #endregion

                    #region 把整理后的数据存入Datatable表

                    //存放数据
                    DataRow dr = dtAttTemp.NewRow();
                    dr[0] = iSfId;
                    dr[1] = iSfName;
                    dr[2] = iSfGroupName;
                    dr[3] = iClassesName;
                    dr[4] = OnlyWorkTime1;
                    dr[5] = OnlyOffDutyTime1;
                    dr[6] = OnlyWorkTime2;
                    dr[7] = OnlyOffDutyTime2;
                    dr[8] = OnlyWorkTime3;
                    dr[9] = OnlyOffDutyTime3;
                    dr[10] = AtDay;//天数
                    dr[11] = AtState;//考勤状态
                    dr[12] = AtSign;//处理标记
                    dtAttTemp.Rows.Add(dr);
                    #endregion

                    //显示到DGV
                    dgvDailyReport.DataSource = dtAttTemp;
                }
            }

            #endregion
        }

        #endregion

        private void btnCreateLog_Click(object sender, EventArgs e)
        {

        }
    }
}
