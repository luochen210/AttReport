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
    public partial class FrmJobs : Form
    {
        OrganizationService objJosService = new OrganizationService();

        public FrmJobs()
        {
            InitializeComponent();

            //显示dgv数据
            getJobsDataSet();
        }

        //窗体关闭事件
        private void FrmJobs_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmJobs = null;
        }

        //获取数据源的方法
        private void getJobsDataSet()
        {
            dgvJobs.DataSource = objJosService.GetAllJobsDataSet().Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //验证
            if (objJosService.IsJobNameExisted(txtJob.Text.Trim()))
            {
                MessageBox.Show("职位名重复");
                txtJob.Focus();
                txtJob.SelectAll();
            }
            else
            {
                //封装职位对象
                Organization objJob = new Organization()
                {
                    JobName = txtJob.Text.Trim()
                };
                //插入数据
                objJosService.InsertJob(objJob);

                //更新dgv
                getJobsDataSet();
            }
        }


    }
}
