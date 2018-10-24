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
    public partial class FrmAddNode : Form
    {
        const string CBOSTR = "请选择或输入内容！";

        JobListService objJobList = new JobListService();

        public FrmAddNode()
        {
            InitializeComponent();

            //获取公司名
            string CompanyName = objJobList.GetCompany();

            //UI启动时获取部门列表
            this.cboDepartment.DataSource = objJobList.GetDepartmentList(CompanyName);
            this.cboDepartment.DisplayMember = "DepartmentName";
            this.cboDepartment.ValueMember = "DepartmentId";
            this.cboDepartment.SelectedIndex = -1;//默认不选中
            this.cboDepartment.Text = CBOSTR;//默认显示提示

            //UI启动时显示创建组别提示
            this.cboDtGroup.Text = CBOSTR;
        }

        //保存数据
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //如果公司名为空，则用lbl输出提示
            if (cboCompanyName.Text == null)
            {
                this.lblCompanyTips.Text = "请输入或选择公司！";
                return;
            }
            //如果部门名为空，则用lbl输出提示
            else if (cboDepartment.Text == CBOSTR)
            {
                this.lblDepartmentTips.Text = "请输入或选择部门！";
                return;
            }
            //如果组别名为空，则用lbl输出提示
            else if (cboDtGroup.Text == CBOSTR)
            {
                this.lblDtGroupTips.Text = "请输入或选择组别！";
                return;
            }


            //根据cbo查询数据库里的公司名
            string CpName = objJobList.CompanyNumber(this.cboCompanyName.Text.Trim());//用于数据写入时判断数据是否重复
            //根据cbo查询数据库里的部门名
            string DtName = objJobList.DepartmentNumber(this.cboDepartment.Text.Trim());//用于数据写入时判断数据是否重复
            //根据cbo查询数据库里的组别名
            string GpName = objJobList.DtGroupNumber(this.cboDtGroup.Text.Trim()); //用于数据写入时判断数据是否重复


            //如果cbo数据与数据库数据不重复，则写入公司名数据
            if (CpName == "")
            {
                this.lblCompanyTips.Text = "";
                JobList objJobs = new JobList()
                {
                    CompanyName = cboCompanyName.Text.Trim()                    
                };
                objJobList.InsertCompany(objJobs);
            }
            //如果cbo数据与数据库数据不重复，则写入部门名数据
            else if (DtName == "")
            {
                int CompanyId=objJobList.
                this.lblDepartmentTips.Text = "";
                JobList objJobs = new JobList()
                {
                    CyId = CompanyId;
                    DepartmentName = cboDepartment.Text.Trim()
                    
                };
                objJobList.InsertDepartment(objJobs);
            }
            //如果cbo数据与数据库数据不重复，则写入组别名数据
            else if (GpName == "")
            {
                this.lblDepartmentTips.Text = "";
                JobList objJobs = new JobList()
                {
                    DtGroupName = cboDtGroup.Text.Trim()
                };
                objJobList.InsertDtGroup(objJobs);
            }

        }


        #region 窗体激活与关闭

        private void FrmAddNode_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmAddNode = null;//当窗体关闭时，将窗体对象清理掉
        }

        #endregion


    }
}
