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
        ClassesTimesService objClassesService = new ClassesTimesService();

        List<TimesManage> cboDataSource;//cbo数据源成员变量

        public FrmClassesTimes()
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
            DataTable dgvClassesTable= objClassesService.GetClassesDataSet().Tables[0];//获取数据

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
                return;
            }

            if (cboTimes1.Text.Trim() == "")
            {
                MessageBox.Show("时段名称1不能为空！");
                return;
            }
            if (cboTimes2.Text.Trim() == "")
            {
                MessageBox.Show("时段2名称不能为空！");
                return;
            }

            //封装对象
            ClassesTimes objClasses = new ClassesTimes()
            {
                ClassesName = txtClassesName.Text.Trim(),
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


        #region 窗口关闭时清理对象

        //窗口关闭时清理对象
        private void FrmClassesTimes_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmClassesTimes = null;
        }


        #endregion
    }
}
