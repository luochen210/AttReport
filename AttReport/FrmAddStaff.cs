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
    public partial class FrmAddStaff : Form
    {
        OrganizationService objJobListService = new OrganizationService();
        StaffService objStaffService = new StaffService();

        public FrmAddStaff()
        {
            InitializeComponent();

            //获取公司名
            var CompanyList = objJobListService.GetAllCompanyList();


            if (CompanyList.Count>0)
            {
                //UI启动时获取部门列表
                this.cboDepartment.DataSource = objJobListService.GetAllDepartmentList(CompanyList[0].CompanyName);
                this.cboDepartment.DisplayMember = "DepartmentName";
                this.cboDepartment.ValueMember = "DepartmentId";
                this.cboDepartment.SelectedIndex = -1;//默认不选中
            }

            //加载职位列表
            cboJob.DataSource = objJobListService.GetAllJobList();
            cboJob.DisplayMember = "JobName";
            cboJob.ValueMember = "JobId";
            cboJob.SelectedIndex = -1;//默认不选中
        }

        //根据部门获取组别的事件
        private void GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取组别
            this.cboGroup.DataSource = objJobListService.GetAllGroupList(this.cboDepartment.Text.Trim());
            this.cboGroup.DisplayMember = "DtGroupName";
            this.cboGroup.ValueMember = "DtGroupId";
            this.cboGroup.SelectedIndex = -1;//默认不选中
        }

        ////根据组别获取职位列表的事件
        //private void JobList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //获取职位
        //    this.cboJob.DataSource = objJobListService.GetAllJobList(this.cboGroup.Text.Trim());
        //    this.cboJob.DisplayMember = "JobName";
        //    this.cboJob.ValueMember = "JobId";
        //    this.cboJob.SelectedIndex = -1;//默认不选中
        //}

        //按回车调用验证按钮的事件
        private void btnExamine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnExamine.Focus();
                btnExamine_Click(sender, e);   //调用验证按钮的事件处理代码
            }
        }

        //验证身份证号码，并且计算相关信息
        private void btnExamine_Click(object sender, EventArgs e)
        {
            if (Common.DataValidate.CheckIDCard(txtIDCard.Text.Trim()))
            {
                this.lblExamineResult.Text = "号码正确！";

                //如果身份证件合法，则设置焦点为姓名输入框
                this.txtName.Focus();

                //获得新增员工的工号,D字开头
                txtJobNo.Text = "D" + objStaffService.GetStaffId();

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
            }
            else
            {
                this.lblExamineResult.Text = "号码非法！";
                this.txtIDCard.Text = null;
                this.txtIDCard.Focus();

                var list = cboDepartment.Items;
                
            }
        }

        //回车键模拟TAB键并验证输入的数据
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
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
                //验证婚姻
                if (this.cboMarriage.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择婚姻状态！", "提示信息");
                    this.cboMarriage.Focus();
                    return;
                }
                //验证部门
                if (this.cboDepartment.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择部门！", "提示信息");
                    this.cboDepartment.Focus();
                    return;
                }
                //验证组别
                if (this.cboGroup.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择组别！", "提示信息");
                    this.cboGroup.Focus();
                    return;
                }
                //验证职位
                if (this.cboJob.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择职位！", "提示信息");
                    this.cboJob.Focus();
                    return;
                }
                //验证卡号
                if (this.txtAttCardNo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("卡号不能为空！", "提示信息");
                    this.txtAttCardNo.Focus();
                    return;
                }
                //验证学历
                if (this.cboEducation.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择学历！", "提示信息");
                    this.cboEducation.Focus();
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
                //验证入职日期
                if (this.dtpEntryDate.Text.Trim().Length == 0)
                {
                    MessageBox.Show("入职日期不能为空！", "提示信息");
                    this.dtpEntryDate.Focus();
                    return;
                }
                //验证手机号
                if (this.txtMobilePhone.Text.Trim().Length == 0)
                {
                    MessageBox.Show("手机号不能为空！", "提示信息");
                    this.txtMobilePhone.Focus();
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

        //选取入职时间后，获取工龄的事件
        private void GetSeniority_CloseUp(object sender, EventArgs e)
        {
            //获取工龄
            int seniority = DateTime.Now.Year - Convert.ToDateTime(this.dtpEntryDate.Text).Year;
            this.txtSeniority.Text = seniority.ToString();
        }

        //保存员工资料
        private void btnSaveStaff_Click(object sender, EventArgs e)
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
            //验证婚姻
            if (this.cboMarriage.SelectedIndex == -1)
            {
                MessageBox.Show("请选择婚姻状态！", "提示信息");
                this.cboMarriage.Focus();
                return;
            }
            //验证部门
            if (this.cboDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("请选择部门！", "提示信息");
                this.cboDepartment.Focus();
                return;
            }
            //验证组别
            if (this.cboGroup.SelectedIndex == -1)
            {
                MessageBox.Show("请选择组别！", "提示信息");
                this.cboGroup.Focus();
                return;
            }
            //验证职位
            if (this.cboJob.SelectedIndex == -1)
            {
                MessageBox.Show("请选择职位！", "提示信息");
                this.cboJob.Focus();
                return;
            }
            //验证卡号
            if (this.txtAttCardNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("卡号不能为空！", "提示信息");
                this.txtAttCardNo.Focus();
                return;
            }
            //验证学历
            if (this.cboJob.SelectedIndex == -1)
            {
                MessageBox.Show("请选择学历！", "提示信息");
                this.cboJob.Focus();
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

            #region 封装员工对象

            //删除工号中的D
            //string strJobNo = txtJobNo.Text.Substring(1);//截取第1个字符起的字符，

            Staff objStaff = new Staff()
            {
                //JobNo = Convert.ToInt32(strJobNo),//工号和员工ID
                SfAttCardNo = txtAttCardNo.Text.Trim(),
                SfDepartmentName = cboDepartment.Text.Trim(),
                SfDtGroupName = cboGroup.Text.Trim(),
                SfJobName = cboJob.Text.Trim(),
                SfName = this.txtName.Text.Trim(),
                SfGender = this.cboGender.Text.Trim(),
                SfAge = Convert.ToInt32(this.txtAge.Text.Trim()),
                SfSeniority = Convert.ToDouble(this.txtAge.Text.Trim()),
                SfMarriage = this.cboMarriage.Text.Trim(),
                SfEducation = this.cboEducation.Text.Trim(),
                SfMajor = txtMajor.Text.Trim(),
                SfNativePlace = txtNativePlace.Text.Trim(),
                SfEntryDate = Convert.ToDateTime(dtpEntryDate.Text.Trim()),
                SfBirthDate = Convert.ToDateTime(dtpBirthDate.Text.Trim()),
                SfDomicile = txtDomicile.Text.Trim(),
                SfResidence = txtRelation.Text.Trim(),
                SfIntroducer = txtIntroducer.Text.Trim(),
                SfFriend = txtFriend.Text.Trim(),
                SfRelation = txtRelation.Text.Trim(),
                SfFriendsPhone = txtFriendPhone.Text.Trim(),
            };

            #endregion

            #region 调用后台数据访问方法添加对象

            try
            {
                if (objStaffService.AddStaff(objStaff) == 1)
                {
                    DialogResult result = MessageBox.Show("新员工添加成功！是否继续添加？", "提示信息", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)//清空用户的输入
                    {
                        foreach (Control item in Controls)
                        {
                            if (item is ComboBox)
                                item.Text = "";
                        }
                        foreach (Control item in Controls)
                        {
                            if (item is DateTimePicker)
                                item.Text = "";
                        }

                        //清除文本框
                        foreach (Control item in this.Controls)
                        {
                            if (item is TextBox)
                                item.Text = "";
                        }
                        this.txtIDCard.Focus();
                    }
                }
                else
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

        }

        #region 窗体激活与关闭

        //关闭窗体
        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //窗体关闭后清理对象
        private void FrmAddStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmAddStaff = null;//当窗体关闭时，将窗体对象清理掉
        }

        #endregion
    }
}
