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
    public partial class FrmShiftManage : Form
    {

        ShiftManageService objShiftServe = new ShiftManageService();

        public FrmShiftManage()
        {
            InitializeComponent();

            //获取数据
            this.CboClassName.DataSource = objShiftServe.GetGetClassList();

            //显示班次
            CboClassName.DisplayMember = "ClassesName";
            //CboClassName.ValueMember = "ClassesId";
            CboClassName.SelectedIndex = -1;//默认不显示

            //设置默认时间
            txtTimesName.Text = "上午";
            dtpWorkTime.Value = Convert.ToDateTime("08:00:00");
            dtpOffDutyTime.Value = Convert.ToDateTime("12:00:00");
            dtpStartCheckIn.Value = Convert.ToDateTime("07:30:00");
            dtpEndCheckIn.Value = Convert.ToDateTime("08:30:00");
            dtpStartSignBack.Value = Convert.ToDateTime("12:00:00");
            dtpEndSignBack.Value = Convert.ToDateTime("12:30:00");
            txtLateTime.Text = "3";
            txtLeftEarly.Text = "0";

        }

        //窗体加载时读取班次表
        private void FrmShiftManage_Load(object sender, EventArgs e)
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




        #region 窗口关闭时清理对象

        //窗口关闭时清理对象
        private void FrmShiftManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmShiftManage = null;
        }

        #endregion


    }
}
