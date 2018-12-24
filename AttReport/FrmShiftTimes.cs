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

        SfWorkTimeService objTimesService = new SfWorkTimeService();
        ShiftTimesService objClassesService = new ShiftTimesService();

        List<SfWorkTime> cboDataSource;//cbo数据源成员变量

        public FrmShiftTimes()
        {
            InitializeComponent();

            cboDataSource = objTimesService.GetTimesNameList();//初始化成员变量

            //获取数据
            this.cboTimes1.DataSource = cboDataSource;
            cboTimes1.DisplayMember = "TimesName";
            cboTimes1.SelectedIndex = -1;//默认不显示

        }


        //窗体加载时读取班次表
        private void FrmClassesTimes_Load(object sender, EventArgs e)
        {
            DataTable dgvClassesTable= objClassesService.GetShiftTimesDataSet().Tables[0];//获取数据

            dgvClassesTable.Columns.Remove("ClassesId");//移除数据

            this.dgvClassses.DataSource = dgvClassesTable;//设置源
        }


        //添加班次
        private void btnClassesAdd_Click(object sender, EventArgs e)
        {
            //验证输入
            if (txtClassesName.Text.Trim() == "")
            {
                MessageBox.Show("班次名称不能为空！");
                txtClassesName.Focus();
                txtClassesName.SelectAll();
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

            if (objClassesService.IsShiftNameExisted(txtClassesName.Text.Trim()))
            {
                MessageBox.Show("班次名称重复！");
                txtClassesName.Focus();
                txtClassesName.SelectAll();
                return;
            }

            //封装对象
            ShiftTimes objClasses = new ShiftTimes()
            {
                ShiftName = txtClassesName.Text.Trim(),
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
            objClassesService.AddShift(objClasses);

            //刷新DGV显示数据
            //获取数据
            DataTable dtClasses=objClassesService.GetShiftTimesDataSet().Tables[0];

            //移除ID列
            dtClasses.Columns.Remove("ClassesId");

            //设置数据源
            dgvClassses.DataSource = dtClasses;

        }

        //修改班次
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //验证
            if (objClassesService.IsShiftNameExisted(txtClassesName.Text.Trim()))
            {
                MessageBox.Show("班次名称重复！");
                txtClassesName.Focus();
                txtClassesName.SelectAll();
                return;
            }
            else
            {
                int index = dgvClassses.CurrentRow.Index;

                //获取原始班次名
                string AgoClassesName = dgvClassses.Rows[index].Cells[0].Value.ToString();

                MessageBox.Show(AgoClassesName);

                ShiftTimes objClasses = new ShiftTimes()
                {
                    ShiftName = txtClassesName.Text.Trim(),
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
                objClassesService.UpdateShift(objClasses, AgoClassesName);

                //更新DGV
                //获取数据
                DataTable dtClasses = objClassesService.GetShiftTimesDataSet().Tables[0];

                //移除ID列
                dtClasses.Columns.Remove("ClassesId");

                //设置数据源
                dgvClassses.DataSource = dtClasses;
            }
        }


        //移除已占用的时段
        private void cboTimes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FrmMain.objFrmClassesTimes != null)
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
            if (FrmMain.objFrmClassesTimes != null)
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
            if (dgvClassses.SelectionMode != DataGridViewSelectionMode.FullColumnSelect)
            {
                int index = dgvClassses.CurrentRow.Index;
                txtClassesName.Text = dgvClassses.Rows[index].Cells[0].Value.ToString();
                cboTimes1.Text = dgvClassses.Rows[index].Cells[1].Value.ToString();
                cboTimes2.Text = dgvClassses.Rows[index].Cells[2].Value.ToString();
                cboTimes3.Text = dgvClassses.Rows[index].Cells[3].Value.ToString();
                chkMonday.Checked = bool.Parse(dgvClassses.Rows[index].Cells[4].Value.ToString());
                chkTuesday.Checked = bool.Parse(dgvClassses.Rows[index].Cells[5].Value.ToString());
                chkWednesday.Checked = bool.Parse(dgvClassses.Rows[index].Cells[6].Value.ToString());
                chkThursday.Checked = bool.Parse(dgvClassses.Rows[index].Cells[7].Value.ToString());
                chkFriday.Checked = bool.Parse(dgvClassses.Rows[index].Cells[8].Value.ToString());
                chkSaturday.Checked = bool.Parse(dgvClassses.Rows[index].Cells[9].Value.ToString());
                chkSunday.Checked = bool.Parse(dgvClassses.Rows[index].Cells[10].Value.ToString());
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
