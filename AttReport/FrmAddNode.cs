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

            //显示创建部门提示
            this.cboDepartment.Text = CBOSTR;//默认显示提示

            //显示创建组别提示
            this.cboDtGroup.Text = CBOSTR;
        }

        //根据公司获取部门列表的事件
        private void DepartmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取组别
            this.cboDepartment.DataSource = objJobList.GetDepartmentList(this.cboCompany.Text.Trim());
            this.cboDepartment.DisplayMember = "DepartmentName";
            this.cboDepartment.ValueMember = "DepartmentId";
            this.cboDepartment.SelectedIndex = -1;//默认不选中

            //显示创建部门提示
            this.cboDepartment.Text = CBOSTR;//默认显示提示

            //显示创建组别提示
            this.cboDtGroup.Text = CBOSTR;
        }

        //根据部门获取组别列表的事件
        private void DtGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取组别
            this.cboDtGroup.DataSource = objJobList.GetAllGroupList(this.cboDepartment.Text.Trim());
            this.cboDtGroup.DisplayMember = "DtGroupName";
            this.cboDtGroup.ValueMember = "DtGroupId";
            this.cboDtGroup.SelectedIndex = -1;//默认不选中

            //显示创建部门提示
            this.cboDepartment.Text = CBOSTR;//默认显示提示

            //显示创建组别提示
            this.cboDtGroup.Text = CBOSTR;
        }


        #region 创建菜单
        private void FrmAddNode_Load(object sender, EventArgs e)
        {
            //创建菜单
            BindTreeView();

            //展开目录
            this.trvwDepartment.ExpandAll();
        }

        #endregion

        #region 创建TreeNode  

        private void BindTreeView()
        {
            TreeNode CompanyNode, DepartmentNode, DtGroupNode;
            DataSet ds = new DataSet();
            DataTable dtTable = new DataTable();
            DataTable dpTable = new DataTable();
            JobListService objService = new JobListService();

            ds = objService.GetCompanyDs();//获得公司数据集

            for (int c = 0; c < ds.Tables[0].Rows.Count; c++)//for循环生成树形菜单
            {
                CompanyNode = new TreeNode(); //创建【公司】根节点对象  
                CompanyNode.Text = ds.Tables[0].Rows[c]["CompanyName"].ToString(); //显示节点的文本  
                CompanyNode.Tag = int.Parse(ds.Tables[0].Rows[c]["CompanyId"].ToString()); //保存对应节点的值  
                this.trvwDepartment.Nodes.Add(CompanyNode);  //将节点填充到树形控件上

                dtTable = objService.GetDepartmentDs(CompanyNode.Text.Trim()).Tables[0];
                for (int d = 0; d < dtTable.Rows.Count; d++)
                {
                    DepartmentNode = new TreeNode(); //创建【部门】节点
                    DepartmentNode.Text = dtTable.Rows[d]["DepartmentName"].ToString(); //显示节点的文本
                    DepartmentNode.Tag = int.Parse(dtTable.Rows[d]["DepartmentId"].ToString());//显示节点对应的值
                    CompanyNode.Nodes.Add(DepartmentNode); //将节点绑定到【公司】中

                    dpTable = objService.GetGroupListDs(DepartmentNode.Text.Trim()).Tables[0];
                    for (int j = 0; j < dpTable.Rows.Count; j++)
                    {
                        DtGroupNode = new TreeNode(); //创建【组别】节点  
                        DtGroupNode.Text = dpTable.Rows[j]["DtGroupName"].ToString(); //显示节点的文本  
                        DtGroupNode.Tag = int.Parse(dpTable.Rows[j]["DtGroupId"].ToString()); //显示节点对应的值  
                        DepartmentNode.Nodes.Add(DtGroupNode); //将该节点填充到【部门】节点中
                    }
                }
            }
            if (this.trvwDepartment.Nodes.Count <= 0)
            {
                this.trvwDepartment.Nodes.Add("请修改为公司名");
            }
        }

        #endregion

        //保存数据
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //如果公司名为空，则用lbl输出提示
            if (cboCompany.Text == null)
            {
                this.lblCompanyTips.Text = "请输入或选择公司！";
                return;
            }
            //如果部门名为空，则用lbl输出提示
            else if (cboDepartment.Text == CBOSTR && cboDepartment.Text == "")
            {
                this.lblCompanyTips.Text = "";
                this.lblDepartmentTips.Text = "请输入或选择部门！";
                return;
            }
            //如果组别名为空，则用lbl输出提示
            else if (cboDtGroup.Text == CBOSTR && cboDtGroup.Text == "")
            {
                this.lblCompanyTips.Text = "";
                this.lblDepartmentTips.Text = "";
                this.lblDtGroupTips.Text = "请输入或选择组别！";
                return;
            }


            //根据cbo查询数据库里的公司名
            string CpName = objJobList.CompanyNumber(this.cboCompany.Text.Trim());//用于数据写入时判断数据是否重复
            //根据cbo查询数据库里的部门名
            string DtName = objJobList.DepartmentNumber(this.cboDepartment.Text.Trim());//用于数据写入时判断数据是否重复
            //根据cbo查询数据库里的组别名
            string GpName = objJobList.DtGroupNumber(this.cboDtGroup.Text.Trim()); //用于数据写入时判断数据是否重复


            //如果cbo数据与数据库数据不重复，则写入公司名数据
            if (CpName == "")
            {
                //封装公司对象
                JobList objJobs = new JobList()
                {
                    CompanyName = cboCompany.Text.Trim()
                };
                //执行数据插入
                objJobList.InsertCompany(objJobs);

                //输出lbl提示
                this.lblCompanyTips.Text = "公司添加成功！";
                this.lblDepartmentTips.Text = "请添加部门！";
                this.lblDtGroupTips.Text = "";
                return;
            }

            //如果cbo数据与数据库数据不重复，则写入部门名数据
            else if (DtName == "")
            {
                if (cboDepartment.Text != CBOSTR)//判断部门是否为默认信息
                {
                    if (CpName != "")
                    {
                        //获得公司ID
                        int CompanyId = Convert.ToInt32(objJobList.GetCompanyId(this.cboCompany.Text.Trim()));
                        //封装部门对象
                        JobList objJobs = new JobList()
                        {
                            CyId = CompanyId,//公司ID
                            DepartmentName = cboDepartment.Text.Trim()
                        };

                        //插入部门数据
                        objJobList.InsertDepartment(objJobs);

                        //输出lbl提示
                        this.lblCompanyTips.Text = "";
                        this.lblDepartmentTips.Text = "部门添加成功！";
                        this.lblDtGroupTips.Text = "请添加组别！";

                    }
                    else
                    {
                        //输出lbl提示
                        this.lblCompanyTips.Text = "请选择或创建公司！";
                        this.lblDepartmentTips.Text = "";
                        this.lblDtGroupTips.Text = "";
                        return;
                    }

                }
                else
                {
                    //输出lbl提示
                    this.lblCompanyTips.Text = "";
                    this.lblDepartmentTips.Text = "请选择或添加部门！";
                    this.lblDtGroupTips.Text = "";
                    return;
                }

            }

            //如果cbo数据与数据库数据不重复，则写入组别名数据
            else if (GpName == "")
            {
                if (cboDtGroup.Text != CBOSTR)//判断组别是否为默认信息
                {
                    if (DtName != "")
                    {
                        //获得部门ID
                        int DepartmentId = Convert.ToInt32(objJobList.GetDepartmentId(this.cboDepartment.Text.Trim()));

                        //封装组别对象
                        JobList objJobs = new JobList()
                        {
                            DtId = DepartmentId,//部门ID
                            DtGroupName = this.cboDtGroup.Text.Trim()
                        };

                        //插入组别数据
                        objJobList.InsertDtGroup(objJobs);

                        //输出lbl提示
                        this.lblCompanyTips.Text = "";
                        this.lblDepartmentTips.Text = "";
                        this.lblDtGroupTips.Text = "组别添加成功！";
                    }
                    else
                    {
                        //输出lbl提示
                        this.lblCompanyTips.Text = "";
                        this.lblDepartmentTips.Text = "";
                        this.lblDtGroupTips.Text = "请创建组别！";
                        return;
                    }
                }
                else
                {
                    //输出lbl提示
                    this.lblCompanyTips.Text = "";
                    this.lblDepartmentTips.Text = "";
                    this.lblDtGroupTips.Text = "请创建组别！";
                    return;
                }

            }
            else
            {
                //输出lbl提示
                this.lblCompanyTips.Text = "";
                this.lblDepartmentTips.Text = "";
                this.lblDtGroupTips.Text = "组别名称已存在！";
                return;
            }

            //停止菜单重绘，防止菜单闪烁
            trvwDepartment.BeginUpdate();
            //刷新菜单
            trvwDepartment.Nodes.Clear();
            //创建菜单
            BindTreeView();
            //展开所有菜单
            this.trvwDepartment.ExpandAll();
            //启用菜单
            trvwDepartment.EndUpdate();

        }

        //删除数据
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //获取公司数据
            string CpNumber = objJobList.CompanyNumber(this.cboCompany.Text.Trim());//用于数据写入时判断数据是否重复
            //获取部门数据
            string DtNumber = objJobList.DepartmentNumber(this.cboDepartment.Text.Trim());//用于数据删除时判断是否存在数据
            //获取组别数据
            string DpNumber = objJobList.DtGroupNumber(this.cboDtGroup.Text.Trim()); //用于数据删除时判断是否存在数据

            //验证数据
            if (this.cboCompany.Text.Trim() == CpNumber)
            {
                if (this.cboDepartment.Text.Trim() == DtNumber)
                {
                    //如果cbo在数据库存在，则删除组别
                    if (this.cboDtGroup.Text.Trim() == DpNumber)
                    {
                        //删除组别信息
                        objJobList.DeleteData("DtGroup", "DtGroupName", this.cboDtGroup.Text.Trim());

                        //重新加载cbo
                        //获取组别
                        this.cboDtGroup.DataSource = objJobList.GetAllGroupList(this.cboDepartment.Text.Trim());
                        this.cboDtGroup.DisplayMember = "DtGroupName";
                        this.cboDtGroup.ValueMember = "DtGroupId";
                        this.cboDtGroup.SelectedIndex = -1;//默认不选中

                        //显示创建组别提示
                        this.cboDtGroup.Text = CBOSTR;

                        //停止菜单重绘，防止菜单闪烁
                        trvwDepartment.BeginUpdate();
                        //刷新菜单
                        trvwDepartment.Nodes.Clear();
                        //创建菜单
                        BindTreeView();
                        //展开所有菜单
                        this.trvwDepartment.ExpandAll();
                        //启用菜单
                        trvwDepartment.EndUpdate();

                        //输出lbl提示
                        this.lblRemoveTips.Text = "组别删除成功！";
                    }
                }
            }

            //验证部门下是否有组别信息
            var iGroupList = objJobList.GetAllGroupList(cboDepartment.Text.Trim());

            //验证是否为有效数据，有效则删除
            if (this.cboCompany.Text.Trim() == CpNumber)
            {
                if (this.cboDepartment.Text.Trim() == DtNumber)
                {
                    //如果部门下无组别信息，则删除部门
                    if (iGroupList == null && this.cboDtGroup.Text.Trim() == CBOSTR)
                    {
                        //删除部门信息
                        objJobList.DeleteData("Department", "DepartmentName", this.cboDepartment.Text.Trim());

                        //cbo重新加载部门列表
                        this.cboDepartment.DataSource = objJobList.GetDepartmentList(CompanyName);
                        this.cboDepartment.DisplayMember = "DepartmentName";
                        this.cboDepartment.ValueMember = "DepartmentId";
                        this.cboDepartment.SelectedIndex = -1;//默认不选中

                        //显示创建部门提示
                        this.cboDepartment.Text = CBOSTR;//默认显示提示
                        //显示创建组别提示
                        this.cboDtGroup.Text = CBOSTR;

                        //停止菜单重绘，防止菜单闪烁
                        trvwDepartment.BeginUpdate();
                        //刷新菜单
                        trvwDepartment.Nodes.Clear();
                        //创建菜单
                        BindTreeView();
                        //展开所有菜单
                        this.trvwDepartment.ExpandAll();
                        //启用菜单
                        trvwDepartment.EndUpdate();

                        //输出lbl提示
                        this.lblRemoveTips.Text = "部门删除成功！";
                    }
                }
            }

            //验证是否为有效数据，有效则删除
            if (this.cboCompany.Text.Trim() == CpNumber)
            {
                //验证公司下是否有部门信息
                var iCompanyList = objJobList.GetDepartmentList(cboCompany.Text.Trim());

                if (iCompanyList == null && this.cboDepartment.Text.Trim() == CBOSTR)
                {
                    //删除公司信息
                    objJobList.DeleteData("Company", "CompanyName", this.cboCompany.Text.Trim());

                    //获取组别
                    this.cboCompany.DataSource = objJobList.GetAllCompany();
                    this.cboCompany.DisplayMember = "DtGroupName";
                    this.cboCompany.ValueMember = "DtGroupId";
                    this.cboCompany.SelectedIndex = -1;//默认不选中

                    //显示创建公司提示
                    this.cboCompany.Text = CBOSTR;
                    //显示创建部门提示
                    this.cboDepartment.Text = CBOSTR;//默认显示提示
                    //显示创建组别提示
                    this.cboDtGroup.Text = CBOSTR;

                    //停止菜单重绘，防止菜单闪烁
                    trvwDepartment.BeginUpdate();
                    //刷新菜单
                    trvwDepartment.Nodes.Clear();
                    //创建菜单
                    BindTreeView();
                    //展开所有菜单
                    this.trvwDepartment.ExpandAll();
                    //启用菜单
                    trvwDepartment.EndUpdate();

                    //输出lbl提示
                    this.lblRemoveTips.Text = "公司删除成功！";
                }
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
