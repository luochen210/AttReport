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
    public partial class FrmSignCard : Form
    {
        private AttRecordService objAttRecordService = new AttRecordService();
        public FrmSignCard()
        {
            InitializeComponent();

            dtpQBeginDate.Text = DateTime.Now.Date.AddMonths(-1).AddDays(1 - DateTime.Now.Day - 1).ToString();//开始时间
            dtpQEndDate.Text = DateTime.Now.Date.ToString();//结束时间

            //获取班次
            var listShiftName = objAttRecordService.GetShiftNameList();
            cboShiftName.DataSource = listShiftName;
            cboShiftName.DisplayMember = "ShiftName";
            cboShiftName.ValueMember = "ShiftId";
            cboShiftName.SelectedIndex = -1;

            //var listDepartment=objAttRecordService.

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

        //查询异常的日报
        private void btnQuery_Click(object sender, EventArgs e)
        {
            btnQuery.Enabled = false;//查询按钮关闭
            //获取日期间隔
            DateTime QBeginDate = DateTime.Parse(dtpQBeginDate.Text.Trim()).Date;//开始日期,从前1天的23:00开始
            DateTime QEndDate = DateTime.Parse(dtpQEndDate.Text.Trim()).Date;//结束日期，到次日的9:00结束

            //获得考勤状态为正常的记录
            dtDayResult = objAttRecordService.GetDayResult(QBeginDate, QEndDate, 0).Tables[0];

            //输出
            dgvDayResult.DataSource = dtDayResult;
            btnQuery.Enabled = true;//查询按钮开启
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
                dtDayResult.DefaultView.RowFilter = string.Format("ClassesName like '{0}'", cboShiftName.Text.Trim());

                if (cboShiftName.Text.Trim() != "")
                {
                    //获取时段名
                    listTimesName = objAttRecordService.GetTimesName(cboShiftName.Text.Trim());

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

        //批量签卡
        private void btnBatch_Click(object sender, EventArgs e)
        {
            btnBatch.Enabled = false;//关闭按钮
            //如果勾选了复选框，则执行批量签卡
            if (chkConfirm2.Checked == true)
            {
                foreach (DataGridViewRow item in dgvDayResult.Rows)
                {
                    //获取时间
                    listTimes = objAttRecordService.GetSfWorkTime(cboTimeName.Text.Trim());//获取工作时间
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

                                //写入数据库
                                objAttRecordService.UpdateDayRepor("WorkTime1", item.Cells["WorkTime1"].Value.ToString(), Convert.ToInt32(item.Cells["AtSign"].Value),
                                    DateTime.Parse(item.Cells["AtDate"].Value.ToString()), Convert.ToInt32(item.Cells["SfId"].Value));
                            }

                            if (string.IsNullOrEmpty(item.Cells["OffDutyTime1"].Value.ToString()))
                            {
                                item.Cells["OffDutyTime1"].Value =
                                    (Convert.ToDateTime(item.Cells["AtDate"].Value).Date
                                    + DateTime.Parse(listTimes[0].OffDutyTime).AddMinutes(1).TimeOfDay).ToString();

                                item.Cells["AtSign"].Value = 2;//更改处理状态为已签卡

                                //写入数据库
                                objAttRecordService.UpdateDayRepor("OffDutyTime1", item.Cells["OffDutyTime1"].Value.ToString(), Convert.ToInt32(item.Cells["AtSign"].Value),
                                    DateTime.Parse(item.Cells["AtDate"].Value.ToString()), Convert.ToInt32(item.Cells["SfId"].Value));
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

                                //写入数据库
                                objAttRecordService.UpdateDayRepor("WorkTime2", item.Cells["WorkTime2"].Value.ToString(), Convert.ToInt32(item.Cells["AtSign"].Value),
                                    DateTime.Parse(item.Cells["AtDate"].Value.ToString()), Convert.ToInt32(item.Cells["SfId"].Value));
                            }

                            if (string.IsNullOrEmpty(item.Cells["OffDutyTime2"].Value.ToString()))
                            {
                                item.Cells["OffDutyTime2"].Value =
                                    (Convert.ToDateTime(item.Cells["AtDate"].Value).Date
                                    + DateTime.Parse(listTimes[0].OffDutyTime).AddMinutes(1).TimeOfDay).ToString();

                                item.Cells["AtSign"].Value = 2;//更改处理状态为已签卡

                                //写入数据库
                                objAttRecordService.UpdateDayRepor("OffDutyTime2", item.Cells["OffDutyTime2"].Value.ToString(), Convert.ToInt32(item.Cells["AtSign"].Value),
                                    DateTime.Parse(item.Cells["AtDate"].Value.ToString()), Convert.ToInt32(item.Cells["SfId"].Value));
                            }
                        }                        
                    }
                    //处理加班,如果加班存在打卡记录则添加加班标记
                    if (!string.IsNullOrEmpty(item.Cells["WorkTime3"].Value.ToString()) ||
                        !string.IsNullOrEmpty(item.Cells["OffDutyTime3"].Value.ToString()))
                    {
                        if (Convert.ToInt32(item.Cells["AtState"].Value) == 11)
                        {
                            item.Cells["AtOvertime"].Value = 11;//平时加班
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先确认是否已处理缺勤！");
            }

            btnBatch.Enabled = true;//开启按钮
        }
    }
}
