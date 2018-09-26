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

namespace AttReport
{
    public partial class FrmAddStaff : Form
    {
        JobListService objJobListService = new JobListService();
        public FrmAddStaff()
        {
            InitializeComponent();

            this.cboDepartment.DataSource = objJobListService.GetDepartmentList();
            this.cboDepartment.DisplayMember = "DepartmentName";
            this.cboDepartment.ValueMember = "DepartmentID";
            this.cboDepartment.SelectedIndex = -1;//默认不选中

        }

        //根据部门获取职位列表的事件
        private void JobList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cboJob.DataSource = objJobListService.GetAllJobList(this.cboDepartment.Text.Trim());
            this.cboJob.DisplayMember = "JobName";
            this.cboJob.ValueMember = "JobID";
            this.cboJob.SelectedIndex = -1;//默认不选中
        }

        //按回车调用验证按钮的事件
        private void btnExamine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnExamine.Focus();
                btnExamine_Click(sender, e);   //调用验证按钮的事件处理代码
            }
        }

        private void FrmAddStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmAddStaff = null;//当窗体关闭时，将窗体对象清理掉
        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnExamine_Click(object sender, EventArgs e)
        {
            if (Common.DataValidate.IsIdentityCard(txtIDCard.Text.Trim()))
            {
                this.lblExamineResult.Text = "正确！";
                this.txtName.Focus();
            }
            else
            {
                this.lblExamineResult.Text = "错误！";
                this.txtIDCard.Text = null;
                this.txtIDCard.Focus();
            }
        }
    }
}
