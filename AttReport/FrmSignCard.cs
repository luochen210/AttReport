﻿using System;
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
    public partial class FrmSignCard : Form
    {
        private AttRecordService objAttRecordService = new AttRecordService();
        public FrmSignCard()
        {
            InitializeComponent();

            dtpQBeginDate.Text = DateTime.Now.Date.AddMonths(-1).AddDays(1 - DateTime.Now.Day - 1).ToString();//开始时间
            dtpQEndDate.Text = DateTime.Now.Date.ToString();//结束时间

            //获取班次
            var listClasses = objAttRecordService.GetClassesList();
            cboClassesName.DataSource = listClasses;
            cboClassesName.DisplayMember = "ClassesName";
            cboClassesName.ValueMember = "ClassesId";
            cboClassesName.SelectedIndex = -1;

        }

        #region 日报表计算方法

        ////根据读取的记录生成日报表
        //public void CreateDayLog(DateTime CBeginDate, DateTime CEndDate)
        //{
        //    TimeSpan ts = CEndDate.Date - CBeginDate.Date;//计算日期差
        //    int mDay = ts.Days;//计算天数

        //    //查询日报
        //    DataTable dtDayRecord = objAttRecordService.GetDayReport(CBeginDate, CEndDate).Tables[0];
        //    //获取员工表
        //    DataTable dtStaff = objAttRecordService.GetAllStaffsDataSet().Tables[0];
        //    //获取所有时段
        //    var iTimesList = objAttRecordService.GetAllTimesList();

        //    //创建日期标记
        //    DateTime iToday = DateTime.Today;//日期标记，用于日报计算

        //    //时段
        //    TimeSpan psAm = TimeSpan.Parse("00:00:00");//1天开始
        //    TimeSpan psPm = TimeSpan.Parse("23:59:59");//1天结束

        //    #region 创建一个Datatable表存放整理好的打卡数据

        //    //缓存表,用于存放整理好的打卡数据
        //    DataTable dtAttTemp = new DataTable("dtAttTemp");
        //    //设定列数据
        //    dtAttTemp.Columns.Add("AtDate", typeof(DateTime)); //日期
        //    dtAttTemp.Columns.Add("SfId", typeof(int));
        //    dtAttTemp.Columns.Add("SfName", typeof(string));
        //    dtAttTemp.Columns.Add("SfGroup", typeof(string));
        //    dtAttTemp.Columns.Add("ClassesName", typeof(string));
        //    dtAttTemp.Columns.Add("WorkTime1", typeof(string));
        //    dtAttTemp.Columns.Add("OffDutyTime1", typeof(string));
        //    dtAttTemp.Columns.Add("WorkTime2", typeof(string));
        //    dtAttTemp.Columns.Add("OffDutyTime2", typeof(string));
        //    dtAttTemp.Columns.Add("WorkTime3", typeof(string));
        //    dtAttTemp.Columns.Add("OffDutyTime3", typeof(string));
        //    dtAttTemp.Columns.Add("AtDay", typeof(double));//考勤天数
        //    dtAttTemp.Columns.Add("AtState", typeof(int));//考勤状态
        //    dtAttTemp.Columns.Add("AtSign", typeof(int));//处理标记

        //    #endregion

        //    //获取每一天的记录
        //    for (int i = 0; i < mDay; i++)
        //    {
        //        #region 计算统计日报

        //        //计算日报（基于员工）
        //        for (int s = 0; s < dtStaff.Rows.Count; s++)
        //        {
        //            double AtDay = 0;//工作天数
        //            int AtState = 0;//考勤状态 考勤状态 0:正常，1:迟到，2:早退，3:未打卡，4:缺勤，5:无薪请假，6:底薪休假，7:全薪休假
        //            int AtSign = 0;//考勤处理标记 0:未处理，1:已计算，2:已签卡，3:已处理假期                

        //            int iSfId = Convert.ToInt32(dtStaff.Rows[s]["SfId"]);//员工Id
        //            string iSfName = dtStaff.Rows[s]["SfName"].ToString();//员工姓名
        //            string iSfGroupName = dtStaff.Rows[s]["SfGroup"].ToString();//员工组别
        //            string iClassesName = dtStaff.Rows[s]["SfShifts"].ToString();//班次名称
        //            var iTimesNameList = objAttRecordService.GetTimesName(iClassesName);//时段名称List

        //            if (iTimesNameList.Count != 0)
        //            {
        //                string iTimesName1 = iTimesNameList[0].TimesName1;//时段1名称
        //                string iTimesName2 = iTimesNameList[0].TimesName2;//时段2名称
        //                string iTimesName3 = iTimesNameList[0].TimesName3;//时段3名称

        //                #region 上下班时间

        //                //根据员工分配的班次时段名称获取上下班时间，处理null异常
        //                TimeSpan WorkTime1 = TimeSpan.Zero;//上班时间1
        //                TimeSpan OffDutyTime1 = TimeSpan.Zero;//下班时间1
        //                if (iTimesName1 != "")
        //                {
        //                    //上班时间1
        //                    WorkTime1 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName1).ToList()[0].WorkTime);
        //                    //下班时间1
        //                    OffDutyTime1 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName1).ToList()[0].OffDutyTime);
        //                }

        //                TimeSpan WorkTime2 = TimeSpan.Zero;//上班时间2
        //                TimeSpan OffDutyTime2 = TimeSpan.Zero;//下班时间2
        //                if (iTimesName2 != "")
        //                {
        //                    //上班时间2
        //                    WorkTime2 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName2).ToList()[0].WorkTime);
        //                    //下班时间2
        //                    OffDutyTime2 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName2).ToList()[0].OffDutyTime);
        //                }

        //                TimeSpan WorkTime3 = TimeSpan.Zero;//上班时间3
        //                TimeSpan OffDutyTime3 = TimeSpan.Zero;//下班时间3
        //                if (iTimesName3 != "")
        //                {
        //                    //上班时间3
        //                    WorkTime3 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName3).ToList()[0].WorkTime);
        //                    //下班时间3
        //                    OffDutyTime3 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName3).ToList()[0].OffDutyTime);
        //                }

        //                #endregion

        //                #region 开始与结束签到时间

        //                //////////////////////////////////////////////////开始与结束签到时间/////////////////////////////////////////////////////////

        //                TimeSpan StartCheckIn1 = TimeSpan.Zero;//开始签到时间1
        //                TimeSpan EndCheckIn1 = TimeSpan.Zero;//结束签到时间1
        //                if (iTimesName1 != "")
        //                {
        //                    //开始签到时间1
        //                    StartCheckIn1 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName1).ToList()[0].StartCheckIn);
        //                    //结束签到时间1
        //                    EndCheckIn1 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName1).ToList()[0].EndCheckIn);
        //                }

        //                TimeSpan StartCheckIn2 = TimeSpan.Zero;//开始签到时间2
        //                TimeSpan EndCheckIn2 = TimeSpan.Zero;//结束签到时间2
        //                if (iTimesName2 != "")
        //                {
        //                    //开始签到时间2
        //                    StartCheckIn2 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName2).ToList()[0].StartCheckIn);
        //                    //结束签到时间2
        //                    EndCheckIn2 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName2).ToList()[0].EndCheckIn);
        //                }

        //                TimeSpan StartCheckIn3 = TimeSpan.Zero;//开始签到时间3
        //                TimeSpan EndCheckIn3 = TimeSpan.Zero;//结束签到时间3
        //                if (iTimesName3 != "")
        //                {
        //                    //开始签到时间3
        //                    StartCheckIn3 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName3).ToList()[0].StartCheckIn);
        //                    //结束签到时间3
        //                    EndCheckIn3 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName3).ToList()[0].EndCheckIn);
        //                }

        //                #endregion

        //                #region 开始与结束签退时间

        //                ///////////////////////////////////////////////开始与结束签退时间/////////////////////////////////////////////////

        //                TimeSpan StartSignBack1 = TimeSpan.Zero;//开始签退时间1
        //                TimeSpan EndSignBack1 = TimeSpan.Zero;//结束签退时间1
        //                if (iTimesName1 != "")
        //                {
        //                    //开始签退时间1
        //                    StartSignBack1 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName1).ToList()[0].StartSignBack);
        //                    //结束签退时间1
        //                    EndSignBack1 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName1).ToList()[0].EndSignBack);
        //                }

        //                TimeSpan StartSignBack2 = TimeSpan.Zero;//开始签退时间2
        //                TimeSpan EndSignBack2 = TimeSpan.Zero;//结束签退时间2
        //                if (iTimesName2 != "")
        //                {
        //                    //开始签退时间2
        //                    StartSignBack2 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName2).ToList()[0].StartSignBack);
        //                    //结束签退时间2
        //                    EndSignBack2 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName2).ToList()[0].EndSignBack);
        //                }

        //                TimeSpan StartSignBack3 = TimeSpan.Zero;//开始签退时间3
        //                TimeSpan EndSignBack3 = TimeSpan.Zero;//结束签退时间3
        //                if (iTimesName3 != "")
        //                {
        //                    //开始签退时间3
        //                    StartSignBack3 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName3).ToList()[0].StartSignBack);
        //                    //结束签退时间3
        //                    EndSignBack3 = TimeSpan.Parse(iTimesList
        //                        .Where(time => time.TimesName == iTimesName3).ToList()[0].EndSignBack);
        //                }
        //                ///////////////////////////////////////////////////////////////////////////////////
        //                #endregion

        //                #region 重新整理打卡记录，根据Id取单日记录                    

        //                //计算统计每位员工的考勤记录
        //                var AttResult = (from log in dtDayRecord.AsEnumerable()//查询集合
        //                                 where Convert.ToInt32(log.Field<Int32>("ClockId")) == iSfId//满足id条件
        //                                 && Convert.ToDateTime(log.Field<DateTime>("ClockRecord").ToString()).Date
        //                                 == (iToday + StartCheckIn1).Date//满足单日条件
        //                                 select log.Field<DateTime>("ClockRecord").ToString()).ToList();//返回记录集合
        //                #endregion

        //                #region 获取唯一打卡值                     

        //                /////////////////////
        //                //创建局部变量接收唯一打卡值
        //                string OnlyWorkTime1 = "";//上班唯一打卡值1
        //                string OnlyOffDutyTime1 = "";//下班唯一打卡值1
        //                string OnlyWorkTime2 = "";//上班唯一打卡值2
        //                string OnlyOffDutyTime2 = "";//下班唯一打卡值2
        //                string OnlyWorkTime3 = "";//上班唯一打卡值3
        //                string OnlyOffDutyTime3 = "";//下班唯一打卡值3
        //                                             ////////////////////////////////////////////

        //                //上班打卡1---大于等于开始签到时间，小于下班开始签退时间，包含迟到（取第一）
        //                OnlyWorkTime1 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= StartCheckIn1
        //                && DateTime.Parse(at).TimeOfDay < StartSignBack1).FirstOrDefault();
        //                //下班打卡1---大于第一次上班结束签到时间，小于第二次上班开始签到时间，包含早退（取最后）
        //                OnlyOffDutyTime1 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay > EndCheckIn1
        //                && DateTime.Parse(at).TimeOfDay < StartCheckIn2).LastOrDefault();

        //                //第二次上班
        //                if (WorkTime2 != TimeSpan.Zero && OffDutyTime2 != TimeSpan.Zero)
        //                {
        //                    //上班打卡2
        //                    OnlyWorkTime2 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= StartCheckIn2
        //                    && DateTime.Parse(at).TimeOfDay < StartSignBack2).FirstOrDefault();
        //                    //下班打卡2
        //                    OnlyOffDutyTime2 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay > EndCheckIn2
        //                    && DateTime.Parse(at).TimeOfDay < StartCheckIn3).LastOrDefault();

        //                    //处理延迟下午下班加班的异常/////////////////////////////////////////////////////////////////////////
        //                    if (iClassesName == "办公职员" && OnlyOffDutyTime2 == null)//待修改完善的代码，不应定死班次
        //                    {
        //                        //获取下班时间后的打卡记录
        //                        var OffDutyList = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= OffDutyTime2
        //                        && DateTime.Parse(at).TimeOfDay < psPm).ToList();//psPm=23:59:59

        //                        //获取最后的打卡记录
        //                        if (OffDutyList.Count != 0)
        //                        {
        //                            //自动签卡，签下班时间
        //                            OnlyOffDutyTime2 = DateTime.Parse((iToday + OffDutyTime2).ToString())
        //                                .AddMinutes(3).AddSeconds(33).ToString(); //为下班时间加33分33秒
        //                        }
        //                    }
        //                }

        //                //第三次上班
        //                if (WorkTime3 != TimeSpan.Zero && OffDutyTime3 != TimeSpan.Zero)
        //                {
        //                    //上班打卡3（加班），取大于晚上加班的第一个打卡记录
        //                    OnlyWorkTime3 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= StartCheckIn3
        //                    && DateTime.Parse(at).TimeOfDay < psPm).FirstOrDefault();//psPm=23:59:59

        //                    //下班打卡3（加班），取晚上加班的最后一个打卡记录
        //                    OnlyOffDutyTime3 = AttResult.Where(at => DateTime.Parse(at).TimeOfDay >= StartCheckIn3
        //                    && DateTime.Parse(at) < DateTime.Parse(iToday + StartCheckIn1.ToString()).AddDays(1)).LastOrDefault();//次日上班开始签到时间
        //                }

        //                //处理两班倒和三班倒加班异常
        //                if (WorkTime2 == TimeSpan.Zero && OffDutyTime2 == TimeSpan.Zero && WorkTime3 == TimeSpan.Zero && OffDutyTime3 == TimeSpan.Zero)
        //                {
        //                    //获取下班时间后到次日上班开始签到时间的打卡记录
        //                    var OffDutyList = AttResult.Where(at => DateTime.Parse(at).TimeOfDay > EndCheckIn1
        //                    && DateTime.Parse(at) < DateTime.Parse((iToday + StartCheckIn1).ToString()).AddDays(1)).ToList();

        //                    //获取最后的打卡记录
        //                    if (OffDutyList.Count != 0)
        //                    {
        //                        //自动签卡，签下班时间
        //                        OnlyOffDutyTime1 = DateTime.Parse(OffDutyList.LastOrDefault()).ToString(); //取最后一个打卡记录
        //                    }
        //                }

        //                #endregion

        //                #region 处理考勤

        //                /*处理考勤
        //                 * 
        //                 * 注意，处理考勤的对象是单次单条记录，不是一天的记录！！！
        //                 * int AtState = 0;//考勤状态 0:正常，1:迟到，2:早退，3:未打卡，4:缺勤(旷工)，5:无薪请假，6:底薪休假，7:全薪休假
        //                 * int AtSign = 0;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
        //                 * 20181217增加各种缺勤处理
        //                 * 
        //                */

        //                #region 处理正班考勤                    
        //                //计算正班天数--如果不是多班倒，并且打卡值不为""，则天数增加
        //                if (iTimesName2 != "" && iTimesName3 != "")
        //                {
        //                    if (OnlyWorkTime1 != null && OnlyOffDutyTime1 != null)//上午
        //                    {
        //                        AtDay = AtDay + 0.5;//考勤天数加半天
        //                    }
        //                    else//处理上午缺勤
        //                    {
        //                        AtState = 4;//缺勤,考勤状态 0:正常，1:迟到，2:早退，3:未打卡，4:缺勤（旷工），5:无薪请假，6:底薪休假，7:全薪休假
        //                        AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
        //                    }


        //                    if (OnlyWorkTime2 != null && OnlyOffDutyTime2 != null)//下午
        //                    {
        //                        AtDay = AtDay + 0.5;
        //                    }
        //                    else//处理下午缺勤
        //                    {
        //                        AtState = 4;
        //                        AtSign = 1;
        //                    }

        //                    //处理未打卡
        //                    if (OnlyWorkTime1 == null || OnlyOffDutyTime1 == null
        //                        || OnlyWorkTime2 == null || OnlyOffDutyTime2 == null
        //                        || OnlyWorkTime3 == null || OnlyOffDutyTime3 == null)
        //                    {
        //                        AtState = 3;//未打卡
        //                        AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
        //                    }

        //                    if (OnlyWorkTime1 != null)
        //                    {
        //                        //处理迟到
        //                        if (DateTime.Parse(OnlyWorkTime1).TimeOfDay > WorkTime1)
        //                        {
        //                            AtState = 1;//迟到
        //                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
        //                        }
        //                    }

        //                    if (OnlyWorkTime2 != null)
        //                    {
        //                        if (DateTime.Parse(OnlyWorkTime2).TimeOfDay > WorkTime2)
        //                        {
        //                            AtState = 1;//迟到
        //                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
        //                        }
        //                    }

        //                    if (OnlyOffDutyTime1 != null)
        //                    {
        //                        //处理早退
        //                        if (DateTime.Parse(OnlyOffDutyTime1).TimeOfDay > OffDutyTime1)
        //                        {
        //                            AtState = 2;//早退
        //                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
        //                        }
        //                    }

        //                    if (OnlyOffDutyTime2 != null)
        //                    {
        //                        if (DateTime.Parse(OnlyOffDutyTime2).TimeOfDay > OffDutyTime2)
        //                        {
        //                            AtState = 2;//早退
        //                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
        //                        }
        //                    }

        //                }

        //                #endregion

        //                #region 处理多班倒考勤

        //                //计算多班倒天数--如果是多班倒，并且打卡值不为""，则天数增加
        //                if (iTimesName2 == "" && iTimesName3 == "")
        //                {
        //                    if (OnlyWorkTime1 != null && OnlyOffDutyTime1 != null)
        //                    {
        //                        AtDay = AtDay + 1;
        //                    }

        //                    /*处理考勤
        //                     * 
        //                     * int AtState = 0;//考勤状态 0:正常，1:迟到，2:早退，3:未打卡，4:缺勤(旷工)，5:无薪请假，6:底薪休假，7:全薪休假
        //                     * int AtSign = 0;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
        //                     * 
        //                    */

        //                    //处理未打卡
        //                    if (OnlyWorkTime1 == null || OnlyOffDutyTime1 == null)
        //                    {
        //                        AtState = 3;
        //                        AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
        //                    }

        //                    if (OnlyWorkTime1 != null)
        //                    {
        //                        //处理迟到
        //                        if (DateTime.Parse(OnlyWorkTime1).TimeOfDay > WorkTime1)
        //                        {
        //                            AtState = 1;//迟到
        //                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
        //                        }
        //                    }

        //                    if (OnlyOffDutyTime1 != null)
        //                    {
        //                        //处理早退
        //                        if (DateTime.Parse(OnlyOffDutyTime1).TimeOfDay > OffDutyTime1)
        //                        {
        //                            AtState = 2;//迟到
        //                            AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
        //                        }
        //                    }

        //                    //处理缺勤(加班除外)
        //                    if (OnlyWorkTime1 == null && OnlyOffDutyTime1 == null)
        //                    {
        //                        AtState = 4;
        //                        AtSign = 1;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
        //                        if (AtDay != 0)
        //                        {
        //                            AtDay = AtDay - 1;
        //                        }
        //                    }
        //                }

        //                #endregion

        //                #endregion

        //                #region 把整理后的数据存入Datatable表

        //                //存放数据
        //                DataRow dr = dtAttTemp.NewRow();
        //                dr[0] = AtDate;
        //                dr[1] = iSfId;
        //                dr[2] = iSfName;
        //                dr[3] = iSfGroupName;
        //                dr[4] = iClassesName;
        //                dr[5] = OnlyWorkTime1;
        //                dr[6] = OnlyOffDutyTime1;
        //                dr[7] = OnlyWorkTime2;
        //                dr[8] = OnlyOffDutyTime2;
        //                dr[9] = OnlyWorkTime3;
        //                dr[10] = OnlyOffDutyTime3;
        //                dr[11] = AtDay;//天数
        //                dr[12] = AtState;//考勤状态
        //                dr[13] = AtSign;//处理标记
        //                dtAttTemp.Rows.Add(dr);
        //                #endregion
        //            }
        //        }
        //        #endregion
        //    }

        //    //显示到DGV
        //    dgvDayReport.DataSource = dtAttTemp;

        //    #region 数据批量对比去重

        //    //读取数据库已有数据
        //    DataTable PasDayReport = objAttRecordService.GetDayReport(CBeginDate, CEndDate).Tables[0];

        //    //求差集结果，
        //    IEnumerable<DataRow> drResult = dtAttTemp.AsEnumerable().Except(PasDayReport.AsEnumerable(), DataRowComparer.Default);

        //    //处理空结果的异常
        //    if (drResult.Count() > 0)//如果序列元素的个数>0，则写入数据，否则跳过
        //    {
        //        //接收不重复的数据
        //        DataTable dtResult = drResult.CopyToDataTable();
        //        //批量写入数据库
        //        SQLHelper.UpdataByBulk(dtResult, "DayReport");
        //    }

        //    #endregion
        //}

        #endregion


        /*处理考勤
         * 
         * 注意，处理考勤的对象是单次单条记录，不是一天的记录！！！
         * int AtState = 0;//考勤状态 0:正常，1:迟到，2:早退，3:未打卡，4:缺勤(旷工)，5:无薪请假，6:底薪休假，7:全薪休假
         * int AtSign = 0;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
         * 20181217增加各种缺勤处理
         * 
         */

        DataTable dtDayResult = null;
        List<TimesManage> listTimes = null;

        //查询异常的日报
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //获取日期间隔
            DateTime QBeginDate = DateTime.Parse(dtpQBeginDate.Text.Trim()).Date;//开始日期,从前1天的23:00开始
            DateTime QEndDate = DateTime.Parse(dtpQEndDate.Text.Trim()).Date;//结束日期，到次日的9:00结束

            //获得考勤状态为正常的记录
            dtDayResult = objAttRecordService.GetDayResult(QBeginDate, QEndDate, 0).Tables[0];

            //输出
            dgvDayResult.DataSource = dtDayResult;

        }

        //关闭窗体事件
        private void FrmSignCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmSignCard = null;
        }

        private void cboClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtDayResult != null)
            {
                //根据cbo值查筛选
                dtDayResult.DefaultView.RowFilter = string.Format("ClassesName like '{0}'", cboClassesName.Text.Trim());

                if (cboClassesName.Text.Trim()!="")
                {
                    //获取时段名
                    var listTimesName = objAttRecordService.GetTimesName(cboClassesName.Text.Trim());

                    //List列转行
                    List<string> timesNameList = new List<string>();
                    timesNameList.Add(listTimesName[0].TimesName1);
                    timesNameList.Add(listTimesName[0].TimesName2);
                    timesNameList.Add(listTimesName[0].TimesName3);

                    //设置源
                    cboTimeName.DataSource = timesNameList;
                    cboTimeName.SelectedIndex = -1;
                }

            }

        }

        private void cboTimeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTimeName.Text.Trim() != "")
            {
                listTimes = objAttRecordService.GetTimes(cboTimeName.Text.Trim());

                List<string> timesList = new List<string>();
                timesList.Add(listTimes[0].WorkTime);
                timesList.Add(listTimes[0].OffDutyTime);

                cboTime.DataSource = timesList;
                cboTime.SelectedIndex = -1;
            }

        }

        //批量签卡
        private void btnBatch_Click(object sender, EventArgs e)
        {
            //获取签卡时间
            DateTime time =DateTime.Parse(cboTime.Text.Trim());

            foreach (DataGridViewRow item in dgvDayResult.Rows)
            {
                //if (item.Cells["AtState"]==4)
                //{

                //    item.Cells[""].Value = time;
                //}
            }
        }
    }
}
