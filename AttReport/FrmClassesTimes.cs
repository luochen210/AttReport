using System;
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
    public partial class FrmClassesTimes : Form
    {

        TimesManageService objTimesService = new TimesManageService();

        public FrmClassesTimes()
        {
            InitializeComponent();

            //获取数据
            this.cboTimes1.DataSource = objTimesService.GetTimesNameList();
            cboTimes1.DisplayMember = "TimesName";
            cboTimes1.SelectedIndex = -1;//默认不显示

        }


        //窗体加载时读取班次表
        private void FrmClassesTimes_Load(object sender, EventArgs e)
        {
            //this.dgvClassses.DataSource = objShiftServe.GetClassDataSet().Tables[0];
        }


        //添加班次
        private void btnClassesAdd_Click(object sender, EventArgs e)
        {
            //if (CboClassName.Text.Trim() == "")
            //{
            //    MessageBox.Show("班次名称不能为空！");
            //    return;
            //}

            //if (txtTimesName.Text.Trim() == "")
            //{
            //    MessageBox.Show("时段名称不能为空！");
            //    return;
            //}
            //if (txtLateTime.Text.Trim() == "")
            //{
            //    MessageBox.Show("迟到分种数不能为空！");
            //    return;
            //}
            //if (txtLeftEarly.Text.Trim() == "")
            //{
            //    MessageBox.Show("早退分钟数不能为空！");
            //    return;
            //}
            //if (txtDayNumber.Text.Trim() == "")
            //{
            //    MessageBox.Show("天数不能为空！");
            //    return;
            //}

            //ShiftManage objShift = new ShiftManage()
            //{
            //    ClassesName = CboClassName.Text.Trim(),
            //    TimesName = txtTimesName.Text.Trim(),
            //    WorkTime = dtpWorkTime.Text.Trim(),
            //    OffDutyTime = dtpOffDutyTime.Text.Trim(),
            //    StartCheckIn = dtpStartCheckIn.Text.Trim(),
            //    EndCheckIn = dtpEndCheckIn.Text.Trim(),
            //    StartSignBack = dtpStartSignBack.Text.Trim(),
            //    EndSignBack = dtpEndSignBack.Text.Trim(),

            //    LateTime = Convert.ToInt32(txtLateTime.Text.Trim()),
            //    LeftEarly = Convert.ToInt32(txtLeftEarly.Text.Trim()),

            //    DayNumber = Convert.ToDouble(txtDayNumber.Text.Trim()),

            //    Monday = Convert.ToInt32(chkMonday.Checked),
            //    Tuesday = Convert.ToInt32(chkTuesday.Checked),
            //    Wednesday = Convert.ToInt32(chkWednesday.Checked),
            //    Thursday = Convert.ToInt32(chkThursday.Checked),
            //    Friday = Convert.ToInt32(chkFriday.Checked),
            //    Saturday = Convert.ToInt32(chkSaturday.Checked),
            //    Sunday = Convert.ToInt32(chkSunday.Checked)
            //};

            ////插入数据
            //objShiftServe.AddTimes(objShift);

            ////刷新DGV
            //dgvClassses.DataSource = objShiftServe.GetClassDataSet().Tables[0];


            ////清空数据
            //foreach (Control item in Controls)
            //{
            //    if (item is TextBox)
            //    {
            //        item.Text = "";
            //    }

            //    else if (item is ComboBox)
            //    {
            //        item.Text = "";
            //    }

            //    else if (item is DateTimePicker)
            //    {
            //        item.Text = null;
            //    }
            //}

            //lblTips.Text = "数据添加成功！";
        }



        //移除已占用的时段
        private void cboTimes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FrmMain.objFrmClassesTimes != null)
            {
                var cboTempDataList = objTimesService.GetTimesNameList();//获取集合

                for (int i = cboTempDataList.Count - 1; i >= 0; i--) //倒序循环，list.Count-1是因为集合索引是从0开始
                {
                    if (cboTempDataList[i].TimesName == cboTimes1.Text.Trim())//如果索引名称等于cbo已选择的名称
                    {
                        cboTempDataList.Remove(cboTempDataList[i]);//删除对应的索引对象
                    }
                }

                cboTimes2.DataSource = cboTempDataList;
                cboTimes2.DisplayMember = "TimesName";
                cboTimes2.SelectedIndex = -1;//默认不显示
            }

        }

        private void cboTimes2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FrmMain.objFrmClassesTimes != null)
            {
                var cboTempDataList = objTimesService.GetTimesNameList();//获取集合

                for (int i = cboTempDataList.Count - 1; i >= 0; i--) //倒序循环，list.Count-1是因为集合索引是从0开始
                {
                    if (cboTempDataList[i].TimesName == cboTimes1.Text.Trim())//如果索引名称等于cbo已选择的名称
                    {
                        cboTempDataList.Remove(cboTempDataList[i]);//删除对应的索引对象
                    }
                    else if (cboTempDataList[i].TimesName == cboTimes2.Text.Trim())
                    {
                        cboTempDataList.Remove(cboTempDataList[i]);//删除对应的索引对象
                    }
                }

                cboTimes3.DataSource = cboTempDataList;
                cboTimes3.DisplayMember = "TimesName";
                cboTimes3.SelectedIndex = -1;//默认不显示

            }
        }


        #region 窗口关闭时清理对象

        //窗口关闭时清理对象
        private void FrmClassesTimes_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmClassesTimes = null;
        }


        #endregion
    }
}
