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

            //UI启动时获取部门列表
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

        //回车键模拟TAB键
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13||e.KeyValue==9)
            {
                #region  验证数据

                if (this.txtName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("姓名不能为空！", "提示信息");
                    this.txtName.Focus();
                    return;
                }
                if (this.cboGender.Text.Trim().Length == 0)
                {
                    MessageBox.Show("性别不能为空！", "提示信息");
                    this.cboGender.Focus();
                    return;
                }
                //验证部门
                if (this.cboDepartment.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择班级！", "提示信息");
                    return;
                }
                //验证职位
                if (this.cboJob.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择班级！", "提示信息");
                    return;
                }
                //验证学历
                if (this.cboJob.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择学历！", "提示信息");
                    return;
                }
                //验证专业
                if (this.txtMajor.Text.Trim().Length == 0)
                {
                    MessageBox.Show("专业不能为空！", "提示信息");
                    this.txtMajor.Focus();
                    return;
                }
                //验证籍贯
                if (this.txtNativePlace.Text.Trim().Length == 0)
                {
                    MessageBox.Show("籍贯不能为空！", "提示信息");
                    this.txtNativePlace.Focus();
                    return;
                }
                //验证民族
                if (this.txtNation.Text.Trim().Length == 0)
                {
                    MessageBox.Show("民族不能为空！", "提示信息");
                    this.txtNation.Focus();
                    return;
                }
                //验证卡号
                if (this.txtCardNo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("卡号不能为空！", "提示信息");
                    this.txtCardNo.Focus();
                    return;
                }
                //验证手机号
                if (this.txtMobilePhone.Text.Trim().Length == 0)
                {
                    MessageBox.Show("手机号不能为空！", "提示信息");
                    this.txtMobilePhone.Focus();
                    return;
                }
                //验证入职日期
                if (this.dtpEntryDate.Text.Trim().Length == 0)
                {
                    MessageBox.Show("入职日期不能为空！", "提示信息");
                    this.dtpEntryDate.Focus();
                    return;
                }
                //验证出生日期
                if (this.dtpBirthDate.Text.Trim().Length == 0)
                {
                    MessageBox.Show("出生不能为空！", "提示信息");
                    this.dtpBirthDate.Focus();
                    return;
                }
                //验证户籍地址
                if (this.txtAddress1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("户籍地址不能为空！", "提示信息");
                    this.txtAddress1.Focus();
                    return;
                }
                //验证现居地址
                if (this.txtAddress2.Text.Trim().Length == 0)
                {
                    MessageBox.Show("现居地址不能为空！", "提示信息");
                    this.txtAddress2.Focus();
                    return;
                }
                //联络人
                if (this.txtLiaison.Text.Trim().Length == 0)
                {
                    MessageBox.Show("联络人不能为空！", "提示信息");
                    this.txtLiaison.Focus();
                    return;
                }
                //关系
                if (this.txtLiaison.Text.Trim().Length == 0)
                {
                    MessageBox.Show("关系不能为空！", "提示信息");
                    this.txtLiaison.Focus();
                    return;
                }
                //亲友电话
                if (this.txtFriendsPhone.Text.Trim().Length == 0)
                {
                    MessageBox.Show("关系不能为空！", "提示信息");
                    this.txtFriendsPhone.Focus();
                    return;
                }
                #endregion

                SendKeys.Send("{tab}");
            }
        }

        //UI关闭事件
        private void FrmAddStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmAddStaff = null;//当窗体关闭时，将窗体对象清理掉
        }

        //保存员工资料
        private void btnSaveStaff_Click(object sender, EventArgs e)
        {

        }

        //身份证验证
        private void btnExamine_Click(object sender, EventArgs e)
        {
            if (Common.DataValidate.CheckIDCard(txtIDCard.Text.Trim()))
            {
                this.lblExamineResult.Text = "号码正确！";
                this.txtName.Focus();
            }
            else
            {
                this.lblExamineResult.Text = "号码非法！";
                this.txtIDCard.Text = null;
                this.txtIDCard.Focus();
            }
        }

        //姓名

    }
}
