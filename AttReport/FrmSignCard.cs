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
            var listClasses = objAttRecordService.GetShiftNameList();
            cboClassesName.DataSource = listClasses;
            cboClassesName.DisplayMember = "ShiftName";
            cboClassesName.ValueMember = "ShiftId";
            cboClassesName.SelectedIndex = -1;

        }

        /*处理考勤
         * 
         * 注意，处理考勤的对象是单次单条记录，不是一天的记录！！！
         * int AtState = 0;//考勤状态 0:正常，1:迟到，2:早退，3:未打卡，4:缺勤(旷工)，5:无薪请假，6:底薪休假，7:全薪休假
         * int AtSign = 0;//考勤处理标记 0:未处理，1:已计算，2:已签卡处理，3:已处理假期
         * 20181217增加各种缺勤处理
         * 
         */

        DataTable dtDayResult = null;
        List<SfWorkTime> listTimes = null;
        List<ShiftTimes> listTimesName = null;

        DateTime dtTime = DateTime.Now;

        #region MyRegion

        //获取时间
        private void GetTimeName(string timeName)
        {
            ////获取所有时段
            //listTimes = objAttRecordService.GetAllTimesList();                         

            //#region 上下班时间                            

            ////根据员工分配的班次时段名称获取上下班时间，处理null异常
            //TimeSpan WorkTime1 = TimeSpan.Zero;//上班时间1
            //TimeSpan OffDutyTime1 = TimeSpan.Zero;//下班时间1

            //var attTimes = listTimes.Where(time => time.TimesName == timeName).ToList();

            //#endregion
        }

        #endregion



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

                if (cboClassesName.Text.Trim() != "")
                {
                    //获取时段名
                    listTimesName = objAttRecordService.GetTimesName(cboClassesName.Text.Trim());

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
                listTimes = objAttRecordService.GetSfWorkTime(cboTimeName.Text.Trim());

                //listShiftTimes=objAttRecordService.get

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
            foreach (DataGridViewRow item in dgvDayResult.Rows)
            {
                if (Convert.ToInt32(item.Cells["AtState"].Value) == 3)
                {
                    //时段1---待增加时段空值验证
                    if (cboTimeName.Text.Trim() == listTimesName[0].TimesName1)
                    {
                        if (string.IsNullOrEmpty(item.Cells["WorkTime1"].Value.ToString()))
                        {
                            item.Cells["WorkTime1"].Value =
                            (Convert.ToDateTime(item.Cells["AtDate"].Value).Date
                            + DateTime.Parse(listTimes[0].WorkTime).AddMinutes(-1).TimeOfDay).ToString();

                            item.Cells["AtSign"].Value = 2;//更改处理状态为已签卡
                        }

                        if (string.IsNullOrEmpty(item.Cells["OffDutyTime1"].Value.ToString()))
                        {
                            item.Cells["OffDutyTime1"].Value =
                                (Convert.ToDateTime(item.Cells["AtDate"].Value).Date
                                + DateTime.Parse(listTimes[0].OffDutyTime).AddMinutes(1).TimeOfDay).ToString();

                            item.Cells["AtSign"].Value = 2;//更改处理状态为已签卡
                        }
                    }

                    //时段2---待增加时段空值验证
                    if (cboTimeName.Text.Trim() == listTimesName[0].TimesName2)
                    {
                        if (string.IsNullOrEmpty(item.Cells["WorkTime2"].Value.ToString()))
                        {
                            item.Cells["WorkTime2"].Value =
                                (Convert.ToDateTime(item.Cells["AtDate"].Value).Date
                                + DateTime.Parse(listTimes[0].WorkTime).AddMinutes(-1).TimeOfDay).ToString();

                            item.Cells["AtSign"].Value = 2;//更改处理状态为已签卡
                        }

                        if (string.IsNullOrEmpty(item.Cells["OffDutyTime2"].Value.ToString()))
                        {
                            item.Cells["OffDutyTime2"].Value =
                                (Convert.ToDateTime(item.Cells["AtDate"].Value).Date
                                + DateTime.Parse(listTimes[0].OffDutyTime).AddMinutes(1).TimeOfDay).ToString();

                            item.Cells["AtSign"].Value = 2;//更改处理状态为已签卡
                        }
                    }
                }
            }
        }

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTime.Text.Trim() != "")
            {
                dtTime = DateTime.Parse(cboTime.Text.Trim());
            }
        }
    }
}
