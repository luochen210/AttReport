using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using DAL;
using Models;

namespace AttReport
{
    public partial class FrmTimesManage : Form
    {
        ShiftManageService objShiftServe = new ShiftManageService();

        public FrmTimesManage()
        {
            InitializeComponent();

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

        //启动时加载数据集
        private void FrmTimesManage_Load(object sender, EventArgs e)
        {
            DataTable dtTimesManage = objShiftServe.GetTimesDataSet().Tables[0];//获取TimesManage表

            dtTimesManage.Columns.Remove("TimesId");//移除TimesId列
            dgvTimesManage.DataSource = dtTimesManage;//输出过滤后的数据
        }


        //添加时间段
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTimesName.Text.Trim() == "")
            {
                MessageBox.Show("时段名称不能为空！");
                return;
            }
            if (txtLateTime.Text.Trim() == "")
            {
                MessageBox.Show("迟到分种数不能为空！");
                return;
            }
            if (txtLeftEarly.Text.Trim() == "")
            {
                MessageBox.Show("早退分钟数不能为空！");
                return;
            }

            ShiftManage objTimes = new ShiftManage()
            {
                TimesName = txtTimesName.Text.Trim(),
                WorkTime = dtpWorkTime.Text.Trim(),
                OffDutyTime = dtpOffDutyTime.Text.Trim(),
                StartCheckIn = dtpStartCheckIn.Text.Trim(),
                EndCheckIn = dtpEndCheckIn.Text.Trim(),
                StartSignBack = dtpStartSignBack.Text.Trim(),
                EndSignBack = dtpEndSignBack.Text.Trim(),

                LateTime = Convert.ToInt32(txtLateTime.Text.Trim()),
                LeftEarly = Convert.ToInt32(txtLeftEarly.Text.Trim()),
            };

            //插入数据
            objShiftServe.AddTimes(objTimes);

            //刷新DGV
            dgvTimesManage.DataSource = objShiftServe.GetTimesDataSet().Tables[0];


            //清空数据
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

                else if (item is ComboBox)
                {
                    item.Text = "";
                }

                else if (item is DateTimePicker)
                {
                    item.Text = null;
                }
            }
        }




        #region 窗口关闭时清理对象

        //窗口关闭时清理对象
        private void FrmTimesManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmTimesManage = null;
        }

        #endregion

    }
}
