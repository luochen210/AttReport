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

        ShiftManageService objShift = new ShiftManageService();

        public FrmShiftManage()
        {
            InitializeComponent();

            //获取数据
            this.CboClassName.DataSource = objShift.GetGetClassList();

            //显示班次
            CboClassName.DisplayMember = "ClassesName";
            CboClassName.ValueMember = "ClassesId";
            CboClassName.SelectedIndex = -1;//默认不显示
        }

        //窗体加载时读取班次表
        private void FrmShiftManage_Load(object sender, EventArgs e)
        {
            this.dgvClassses.DataSource = objShift.GetClassTableDs();
        }



        //添加班次
        private void btnClassesAdd_Click(object sender, EventArgs e)
        {
            ShiftManage objShift = new ShiftManage()
            {
                ClassesName = CboClassName.Text.Trim(),
                TimesName=txtTimesName.Text.Trim(),
                WorkTime=dtpWorkTime.Value.Hour&&,





            };
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
