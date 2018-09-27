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
        StaffService objStaffService = new StaffService();
        public FrmAddStaff()
        {
            InitializeComponent();

            //UI启动时获取部门列表
            this.cboDepartment.DataSource = objJobListService.GetDepartmentList();
            this.cboDepartment.DisplayMember = "DepartmentName";
            this.cboDepartment.ValueMember = "DepartmentID";
            this.cboDepartment.SelectedIndex = -1;//默认不选中

            //获得新增员工的工号,D字开头
            txtJobNo.Text = "D"+objStaffService.GetStaffId();

            //启动时设置焦点为身份证输入框
            //this.txtIDCard.Focus();

        }

        //根据部门获取组别和职位列表的事件
        private void JobList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////获取组别
            //this.cboJob.DataSource = objJobListService.GetAllJobList(this.cboDepartment.Text.Trim());
            //this.cboJob.DisplayMember = "JobName";
            //this.cboJob.ValueMember = "JobID";
            //this.cboJob.SelectedIndex = -1;//默认不选中

            //获取职位
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

        //回车键模拟TAB键并验证输入的数据
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 || e.KeyValue == 9)
            {
                #region  验证数据

                if (this.txtIDCard.Text.Trim().Length == 0)
                {
                    MessageBox.Show("身份证号码不能为空！", "提示信息");
                    this.txtIDCard.Focus();
                    return;
                }
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
                    MessageBox.Show("请选择部门！", "提示信息");
                    return;
                }
                //验证部门
                if (this.cboGroup.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择组别！", "提示信息");
                    return;
                }
                //验证职位
                if (this.cboJob.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择职位！", "提示信息");
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
                    MessageBox.Show("出生日期不能为空！", "提示信息");
                    this.dtpBirthDate.Focus();
                    return;
                }
                //验证户籍地址
                if (this.txtDomicile.Text.Trim().Length == 0)
                {
                    MessageBox.Show("户籍地址不能为空！", "提示信息");
                    this.txtDomicile.Focus();
                    return;
                }
                //验证现居地址
                if (this.txtResidence.Text.Trim().Length == 0)
                {
                    MessageBox.Show("现居地址不能为空！", "提示信息");
                    this.txtResidence.Focus();
                    return;
                }
                //联络人
                if (this.txtFriend.Text.Trim().Length == 0)
                {
                    MessageBox.Show("联络人不能为空！", "提示信息");
                    this.txtFriend.Focus();
                    return;
                }
                //关系
                if (this.txtFriend.Text.Trim().Length == 0)
                {
                    MessageBox.Show("关系不能为空！", "提示信息");
                    this.txtFriend.Focus();
                    return;
                }
                //亲友电话
                if (this.txtFriendPhone.Text.Trim().Length == 0)
                {
                    MessageBox.Show("亲友电话为空！", "提示信息");
                    this.txtFriendPhone.Focus();
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

        //验证事件
        private void btnExamine_Click(object sender, EventArgs e)
        {
            if (Common.DataValidate.CheckIDCard(txtIDCard.Text.Trim()))
            {
                this.lblExamineResult.Text = "号码正确！";

                #region 根据身份证号获取生日、性别、籍贯等信息
                string Birthday = "";
                string Gender = "";

                //获取出生日期
                if (txtIDCard.Text.Length == 18)//处理18位的身份证号码从号码中得到生日和性别代码
                {
                    Birthday = txtIDCard.Text.Substring(6, 4) + "-" + txtIDCard.Text.Substring(10, 2) + "-" + txtIDCard.Text.Substring(12, 2);
                    Gender = txtIDCard.Text.Substring(14, 3);
                }
                if (txtIDCard.Text.Length == 15)
                {
                    Birthday = "19" + txtIDCard.Text.Substring(6, 2) + "-" + txtIDCard.Text.Substring(8, 2) + "-" + txtIDCard.Text.Substring(10, 2);
                    Gender = txtIDCard.Text.Substring(12, 3);
                }
                dtpBirthDate.Text = Birthday;

                //获取性别
                if (int.Parse(Gender) % 2 == 0)//性别代码为偶数是女性奇数为男性
                {
                    this.cboGender.Text = "女";
                }
                else
                {
                    this.cboGender.Text = "男";
                }

                //获取年龄
                int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthDate.Text).Year;
                this.txtAge.Text = age.ToString();

                #endregion //获取结束！

                //获取工龄
                int seniority = DateTime.Now.Year - Convert.ToDateTime(this.dtpEntryDate.Text).Year;
                this.txtSeniority.Text = seniority.ToString();



                //如果身份证件合法，则设置焦点为姓名输入框
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
