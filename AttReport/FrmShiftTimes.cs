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
    public partial class FrmShiftTimes : Form
    {

        SfWorkTimeService objSfWorkTimeService = new SfWorkTimeService();
        ShiftTimesService objShiftTimesService = new ShiftTimesService();

        List<SfWorkTime> cboDataSource;//cbo数据源成员变量

        public FrmShiftTimes()
        {
            InitializeComponent();

            cboDataSource = objSfWorkTimeService.GetTimesNameList();//初始化成员变量

            //获取数据
            this.cboTimes1.DataSource = cboDataSource;
            cboTimes1.DisplayMember = "TimesName";
            cboTimes1.SelectedIndex = -1;//默认不显示

        }


        //窗体加载时读取班次表
        private void FrmShiftTimes_Load(object sender, EventArgs e)
        {
            DataTable dgvShiftTable = objShiftTimesService.GetShiftTimesDataSet().Tables[0];//获取数据

            dgvShiftTable.Columns.Remove("ShiftId");//移除数据

            this.dgvShift.DataSource = dgvShiftTable;//设置源
        }


        //添加班次
        private void btnShiftAdd_Click(object sender, EventArgs e)
        {
            //验证输入
            if (txtShiftName.Text.Trim() == "")
            {
                MessageBox.Show("班次名称不能为空！");
                txtShiftName.Focus();
                txtShiftName.SelectAll();
                return;
            }

            if (cboTimes1.Text.Trim() == "")
            {
                MessageBox.Show("时段名称1不能为空！");
                cboTimes1.Focus();
                cboTimes1.SelectAll();
                return;
            }
            if (cboTimes2.Text.Trim() == "")
            {
                MessageBox.Show("时段2名称不能为空！");
                cboTimes2.Focus();
                cboTimes2.SelectAll();
                return;
            }

            if (objShiftTimesService.IsShiftNameExisted(txtShiftName.Text.Trim()))
            {
                MessageBox.Show("班次名称重复！");
                txtShiftName.Focus();
                txtShiftName.SelectAll();
                return;
            }

            //封装对象
            ShiftTimes objShiftTimes = new ShiftTimes()
            {
                ShiftName = txtShiftName.Text.Trim(),
                TimesName1 = cboTimes1.Text.Trim(),
                TimesName2 = cboTimes2.Text.Trim(),
                TimesName3 = cboTimes3.Text.Trim(),

                Monday = Convert.ToInt32(chkMonday.Checked),
                Tuesday = Convert.ToInt32(chkTuesday.Checked),
                Wednesday = Convert.ToInt32(chkWednesday.Checked),
                Thursday = Convert.ToInt32(chkThursday.Checked),
                Friday = Convert.ToInt32(chkFriday.Checked),
                Saturday = Convert.ToInt32(chkSaturday.Checked),
                Sunday = Convert.ToInt32(chkSunday.Checked)
            };



            //插入数据
            objShiftTimesService.AddShift(objShiftTimes);

            //刷新DGV显示数据
            //获取数据
            DataTable dtShift=objShiftTimesService.GetShiftTimesDataSet().Tables[0];

            //移除ID列
            dtShift.Columns.Remove("ShiftId");

            //设置数据源
            dgvShift.DataSource = dtShift;

        }

        //修改班次
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //验证
            if (objShiftTimesService.IsShiftNameExisted(txtShiftName.Text.Trim()))
            {
                MessageBox.Show("班次名称重复！");
                txtShiftName.Focus();
                txtShiftName.SelectAll();
                return;
            }
            else
            {
                int index = dgvShift.CurrentRow.Index;

                //获取原始班次名
                string AgoShiftName = dgvShift.Rows[index].Cells[0].Value.ToString();

                MessageBox.Show(AgoShiftName);

                ShiftTimes objShiftTimes = new ShiftTimes()
                {
                    ShiftName = txtShiftName.Text.Trim(),
                    TimesName1 = cboTimes1.Text.Trim(),
                    TimesName2 = cboTimes2.Text.Trim(),
                    TimesName3 = cboTimes3.Text.Trim(),

                    Monday = Convert.ToInt32(chkMonday.Checked),
                    Tuesday = Convert.ToInt32(chkTuesday.Checked),
                    Wednesday = Convert.ToInt32(chkWednesday.Checked),
                    Thursday = Convert.ToInt32(chkThursday.Checked),
                    Friday = Convert.ToInt32(chkFriday.Checked),
                    Saturday = Convert.ToInt32(chkSaturday.Checked),
                    Sunday = Convert.ToInt32(chkSunday.Checked),
                };

                //插入数据
                objShiftTimesService.UpdateShift(objShiftTimes, AgoShiftName);

                //更新DGV
                //获取数据
                DataTable dtShift = objShiftTimesService.GetShiftTimesDataSet().Tables[0];

                //移除ID列
                dtShift.Columns.Remove("ShiftId");

                //设置数据源
                dgvShift.DataSource = dtShift;
            }
        }


        //移除已占用的时段
        private void cboTimes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FrmMain.objFrmShiftTimes != null)
            {
                cboTimes2.DataSource = null;//清空源

                var cboTempData = cboDataSource;//获取集合

                cboTimes2.DataSource = cboTempData//设置源
                    .Where(item => item.TimesName != cboTimes1.Text.Trim())//排除cboTimes2选择的元素
                    .ToList();//转换为List

                cboTimes2.DisplayMember = "TimesName";
                cboTimes2.SelectedIndex = -1;//默认不显示
            }

        }

        private void cboTimes2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FrmMain.objFrmShiftTimes != null)
            {
                cboTimes3.DataSource = null; //清空源

                var cboTempData = cboDataSource;//获取集合，cboDataSource为成员变量
                cboTimes3.DataSource = cboTempData//设置源
                    .Where(item => item.TimesName != cboTimes1.Text.Trim() && item.TimesName != cboTimes2.Text.Trim())//排除cboTimes1和cboTimes2选择的元素
                    .ToList();//转换为List

                cboTimes3.DisplayMember = "TimesName";
                cboTimes3.SelectedIndex = -1;//默认不显示
            }
        }

        private void dgvClassses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShift.SelectionMode != DataGridViewSelectionMode.FullColumnSelect)
            {
                int index = dgvShift.CurrentRow.Index;
                txtShiftName.Text = dgvShift.Rows[index].Cells[0].Value.ToString();
                cboTimes1.Text = dgvShift.Rows[index].Cells[1].Value.ToString();
                cboTimes2.Text = dgvShift.Rows[index].Cells[2].Value.ToString();
                cboTimes3.Text = dgvShift.Rows[index].Cells[3].Value.ToString();
                chkMonday.Checked = bool.Parse(dgvShift.Rows[index].Cells[4].Value.ToString());
                chkTuesday.Checked = bool.Parse(dgvShift.Rows[index].Cells[5].Value.ToString());
                chkWednesday.Checked = bool.Parse(dgvShift.Rows[index].Cells[6].Value.ToString());
                chkThursday.Checked = bool.Parse(dgvShift.Rows[index].Cells[7].Value.ToString());
                chkFriday.Checked = bool.Parse(dgvShift.Rows[index].Cells[8].Value.ToString());
                chkSaturday.Checked = bool.Parse(dgvShift.Rows[index].Cells[9].Value.ToString());
                chkSunday.Checked = bool.Parse(dgvShift.Rows[index].Cells[10].Value.ToString());
            }
        }


        #region 窗口关闭时清理对象

        //窗口关闭时清理对象
        private void FrmClassesTimes_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmShiftTimes = null;
        }


        #endregion


    }
}
