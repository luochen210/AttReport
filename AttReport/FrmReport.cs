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

        #region 参考代码1
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
        #endregion



        //获取报表

        public void GetMonthlyReport()
        {
            if (dtpStartDate.Text.Trim() == dtpEndDate.Text.Trim())
            {
                MessageBox.Show("开始与结束时间不能相同！");
                return;
            }
            else
            {
                #region 生成报表

                //创建新的Datatable表

                //根据时期区间获取原始记录表
                DataTable dtReport = objRecordService.GetMonthlyReportDataSet(dtpStartDate.Text.Trim(), dtpEndDate.Text.Trim()).Tables[0];

                if (dtReport.Rows.Count != 0)
                {
                    //遍历记录表
                    int index = 0;
                    for (int i = 0; i < dtReport.Rows.Count; i++)
                    {
                        index++;
                        //从记录表获得Id
                        string iSfId = dtReport.Rows[i]["ClockId"].ToString(); //ClockId原始考勤ID
                        //从数据库获得姓名
                        string iSfName = objRecordService.GetStaffList(iSfId).ToString();

                        //获得轮班班次
                        string iSfShiftsName = objRecordService.GetShifts(iSfId);

                        //判断人员是否排班
                        //if (iSfShiftsName == null)
                        //{
                            //lblQueryTips.Text = "请先为：[" + iSfName + "]排班！";
                            //return;

                            //测试用变量///////////////////////////////
                            iSfShiftsName = "生产作业";//测试专用变量//
                           ////////////////////////////////////////////


                            //获得班次时间段list集合
                            var TimesNameList = objRecordService.GetTimesName(iSfShiftsName);//封装了时段名称

                            //获取集合中的班次名称
                            var ClassesName = TimesNameList[0].ClassesName;
                            MessageBox.Show(ClassesName);

                            var TimesName1 = TimesNameList[0].TimesName1;//时段名称1
                            MessageBox.Show(TimesName1);

                            var TimesName2 = TimesNameList[0].TimesName2;//时段名称2
                            MessageBox.Show(TimesName2);

                            var TimesName3 = TimesNameList[0].TimesName3;//时段名称3
                            MessageBox.Show(TimesName3);
                            
                            
                            //var TimesList=




                        //}
                        //else
                        //{
                        //    //获得班次时间段list集合
                        //    var Times = objRecordService.GetTimes(iSfShiftsName);//封装了上班时间和下班时间

                        //    //获取集合中的上班时间
                        //    var WorkTime = Times[0].WorkTime;

                        //    MessageBox.Show(WorkTime);

                        //    var OffDutyTime = Times[1].OffDutyTime;
                        //}


                        //if (DateTime.Parse(dtReport.Rows[i]["ClockRecord"].ToString()) >= DateTime.Parse("01:00"))
                        //{

                        //}
                    }


                    #region 参考代码2

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

                    #endregion

                }
                else
                {
                    lblQueryTips.Text = "没有查到数据！";
                }
                #endregion

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
