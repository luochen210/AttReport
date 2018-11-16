using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using DAL;
using Models;

namespace AttReport
{
    public partial class FrmTimesManage : Form
    {
        TimesManageService objShiftServe = new TimesManageService();

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


        //把dgv内容输出到txt等控件
        private void dgvTimesManage_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTimesManage.SelectionMode != DataGridViewSelectionMode.FullColumnSelect)
            {
                int index = dgvTimesManage.CurrentRow.Index;
                txtTimesName.Text = dgvTimesManage.Rows[index].Cells[0].Value.ToString();
                dtpWorkTime.Text = dgvTimesManage.Rows[index].Cells[1].Value.ToString();
                dtpOffDutyTime.Text = dgvTimesManage.Rows[index].Cells[2].Value.ToString();
                dtpStartCheckIn.Text = dgvTimesManage.Rows[index].Cells[3].Value.ToString();
                dtpEndCheckIn.Text = dgvTimesManage.Rows[index].Cells[4].Value.ToString();
                dtpStartSignBack.Text = dgvTimesManage.Rows[index].Cells[5].Value.ToString();
                dtpEndSignBack.Text = dgvTimesManage.Rows[index].Cells[6].Value.ToString();
                txtLateTime.Text = dgvTimesManage.Rows[index].Cells[7].Value.ToString();
                txtLeftEarly.Text = dgvTimesManage.Rows[index].Cells[8].Value.ToString();
            }

        }


        //添加时间段
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTimesName.Text.Trim() == "")
            {
                MessageBox.Show("时段名称不能为空！");
                txtTimesName.Focus();
                return;
            }
            if (txtLateTime.Text.Trim() == "")
            {
                MessageBox.Show("迟到分种数不能为空！");
                txtLateTime.Focus();
                return;
            }
            if (txtLeftEarly.Text.Trim() == "")
            {
                MessageBox.Show("早退分钟数不能为空！");
                txtLeftEarly.Focus();
                return;
            }

            //验证时段名称
            if (objShiftServe.IsTimesNameExisted(txtTimesName.Text.Trim()))
            {
                MessageBox.Show("时段名称重复");
                txtTimesName.Focus();//设置焦点
                txtTimesName.SelectAll();//选定文本
                return;
            }
            else
            {
                TimesManage objTimes = new TimesManage()
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
                DataTable dtTimesManage = objShiftServe.GetTimesDataSet().Tables[0];//获取TimesManage表

                dtTimesManage.Columns.Remove("TimesId");//移除TimesId列
                dgvTimesManage.DataSource = dtTimesManage;//输出过滤后的数据


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
