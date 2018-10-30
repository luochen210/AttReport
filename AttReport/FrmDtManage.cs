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
    public partial class FrmDtManage : Form
    {
        const string CBOSTR = "请选择或输入内容！";

        OrganizationService objOnServiceList = new OrganizationService();

        public FrmDtManage()
        {
            InitializeComponent();

        }

        #region 窗体启动时加载树形菜单
        private void FrmAddNode_Load(object sender, EventArgs e)
        {
            //创建菜单
            BindTreeView();

            this.trvwDepartment.SelectedNode = null;

            if (this.trvwDepartment.SelectedNode == null)
            {
                this.btnAddCompany.Enabled = false;
                this.btnAddDepartment.Enabled = false;
                this.btnAddDtGroup.Enabled = false;

                this.lblInputTips.ForeColor = Color.DimGray;
                this.lblInputTips.Text = "勾选“添加公司”可以添加公司！";

                this.lblInputTips1.ForeColor = Color.DimGray;
                this.lblInputTips1.Text = "请选择左边的组织节点！";

                this.lblInputTips2.ForeColor = Color.DimGray;
                this.lblInputTips2.Text = "请选择左边的组织节点！";
            }
            this.txtNewNode.Focus();

        }

        #endregion

        #region 创建TreeNode的方法

        private void BindTreeView()
        {
            TreeNode CompanyNode, DepartmentNode, DtGroupNode;
            DataSet ds = new DataSet();
            DataTable dtTable = new DataTable();
            DataTable dpTable = new DataTable();

            OrganizationService objService = new OrganizationService();

            ds = objService.GetCompanyDs();//获得公司数据集

            trvwDepartment.BeginUpdate();//禁树型菜单重绘，防止闪烁

            if (this.trvwDepartment.Nodes.Count != 0)
            {
                trvwDepartment.Nodes.Clear();
            }

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
                this.trvwDepartment.Nodes.Add("请在右边修改此节点");
            }
            //展开目录
            this.trvwDepartment.ExpandAll();

            trvwDepartment.EndUpdate();//开启重绘
        }

        #endregion

        #region 单击节点的事件        
        private void trvwDepartment_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            trvwDepartment.SelectedNode = e.Node;//选中被单击的节点

            //把被选中节点的值显示在txtParentNode
            this.txtParentNode.Text = trvwDepartment.SelectedNode.Text;
            this.txtParentNode1.Text = trvwDepartment.SelectedNode.Text;
            this.txtParentNode2.Text = trvwDepartment.SelectedNode.Text;

            //判断选择的节点
            if (trvwDepartment.SelectedNode != null)
            {
                //获取选择的节点深度
                int stNodeLv = trvwDepartment.SelectedNode.Level;

                if (stNodeLv == 0)
                {
                    this.btnAddCompany.Enabled = false;
                    this.btnAddDepartment.Enabled = true;
                    this.btnAddDtGroup.Enabled = false;
                    this.lblInputTips.ForeColor = Color.Green;
                    this.lblInputTips.Text = "选择公司成功！请输入部门名！";
                }
                else if (stNodeLv == 1)
                {
                    this.btnAddCompany.Enabled = false;
                    this.btnAddDepartment.Enabled = false;
                    this.btnAddDtGroup.Enabled = true;
                    this.lblInputTips.ForeColor = Color.Green;
                    this.lblInputTips.Text = "选择部门成功！请输入组别名！";
                }
                else
                {
                    this.btnAddCompany.Enabled = false;
                    this.btnAddDepartment.Enabled = false;
                    this.btnAddDtGroup.Enabled = false;
                    this.lblInputTips.ForeColor = Color.Red;
                    this.lblInputTips.Text = "勾选“添加公司”可以添加公司";
                }
            }
            else
            {
                //开启添加公司按钮
                this.btnAddCompany.Enabled = true;
                //输出提示
                this.lblInputTips.ForeColor = Color.Red;
                this.lblInputTips.Text = "请输入公司名！";
            }

        }

        #endregion

        //勾选公司
        private void chkCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompany.Checked == true)
            {
                this.trvwDepartment.SelectedNode = null;
                this.btnAddCompany.Enabled = true;
                this.txtParentNode.Text = null;
                this.lblInputTips.ForeColor = Color.Red;
                this.lblInputTips.Text = "提示：请输入公司名！";
            }
            else
            {
                this.trvwDepartment.SelectedNode = null;
                this.btnAddCompany.Enabled = false;
                this.txtParentNode.Text = null;
                this.lblInputTips.ForeColor = Color.DimGray;
                this.lblInputTips.Text = "勾选“添加公司”可以添加公司！";
            }
        }

        //添加公司
        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            txtParentNode.Text = string.Empty;//清空默认内容

            if (txtNewNode.Text.Trim() == string.Empty)//判断内容是否为空
            {
                lblInputTips.Focus();
                lblInputTips.ForeColor = Color.Red;
                lblInputTips.Text = "提示：请输入要添加的公司名称！";
            }
            else if (this.chkCompany.Checked == true)
            {
                //验证公司名称是否重复
                string iCompanyName = objOnServiceList.GetCompanyName(txtNewNode.Text.Trim());
                if (txtNewNode.Text.Trim() != iCompanyName)
                {
                    //封装公司对象
                    Organization objOrg = new Organization()
                    {
                        CompanyName = txtNewNode.Text.Trim()
                    };

                    //插入数据
                    objOnServiceList.InsertCompany(objOrg);

                    //重新生成树型菜单
                    BindTreeView();//重绘方法

                    //输出提示
                    lblInputTips.ForeColor = Color.Green;
                    lblInputTips.Text = "提示：公司名称添加成功！";

                    txtNewNode.Text = string.Empty;//清空信息
                    txtParentNode.Text = null;

                    chkCompany.Checked = false;//清除勾选
                    btnAddCompany.Enabled = false;//禁用按钮
                    txtParentNode.Focus();
                }
                else
                {
                    //输出提示
                    lblInputTips.ForeColor = Color.Red;
                    lblInputTips.Text = "提示：公司名称重复！请重新输入！";
                    txtNewNode.Text = string.Empty;//清空信息
                    txtNewNode.Focus();
                }
            }
            else
            {
                this.lblInputTips.Text = "请勾选【添加公司】";
            }
        }

        //添加部门
        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            if (this.txtParentNode.Text.Trim() == string.Empty || trvwDepartment.SelectedNode == null)
            {
                //设置文本颜色
                this.lblInputTips.ForeColor = Color.Red;
                this.lblInputTips.Text = "提示：请先在左边选择公司！";
                this.txtParentNode.Focus();
            }
            else if (trvwDepartment.SelectedNode.Level == 0)//判断选择的节点是否为公司
            {
                if (this.txtParentNode.Text.Trim() == trvwDepartment.SelectedNode.Text.Trim())
                {
                    //验证新输入的部门名
                    string iDepartmentName = objOnServiceList.GetDepartmentName(this.txtNewNode.Text.Trim());

                    //根据选择的公司名获取公司ID
                    string iCompanyId = objOnServiceList.GetCompanyId(txtParentNode.Text.Trim());

                    if (txtNewNode.Text.Trim() != iDepartmentName)
                    {
                        //封装部门对象
                        Organization objOrg = new Organization()
                        {
                            CyId = Convert.ToInt32(iCompanyId),
                            DepartmentName = txtNewNode.Text.Trim()
                        };

                        //插入部门数据
                        objOnServiceList.InsertDepartment(objOrg);

                        //重新生成树型菜单
                        BindTreeView();//重绘方法

                        //输出提示
                        lblInputTips.ForeColor = Color.Green;
                        lblInputTips.Text = "提示：部门名称添加成功！";

                        txtNewNode.Text = null;//清空信息
                        txtParentNode.Text = null;

                        txtParentNode.Focus();
                    }
                    else
                    {
                        //输出提示
                        lblInputTips.ForeColor = Color.Red;
                        lblInputTips.Text = "提示：部门名称重复！请重新输入！";
                        txtNewNode.Text = string.Empty;//清空信息
                        txtNewNode.Focus();
                    }
                }

            }
            else
            {
                //输出提示
                lblInputTips.ForeColor = Color.Red;
                lblInputTips.Text = "提示：你选择的不是公司节点！";
                txtNewNode.Text = string.Empty;//清空信息
                txtNewNode.Focus();
            }
        }


        //添加组别
        private void btnAddDtGroup_Click(object sender, EventArgs e)
        {
            if (this.txtParentNode.Text.Trim() == string.Empty || trvwDepartment.SelectedNode == null)
            {
                //设置文本颜色
                this.lblInputTips.ForeColor = Color.Red;
                this.lblInputTips.Text = "提示：添加组别时必须先在左边选择部门！";
                this.txtParentNode.Focus();
            }
            else if (trvwDepartment.SelectedNode.Level == 1)//判断选择的节点是否为部门
            {
                if (this.txtParentNode.Text.Trim() == trvwDepartment.SelectedNode.Text.Trim())
                {
                    //验证新输入的组别名称
                    string iDtGroupName = objOnServiceList.GetDtGroupName(this.txtNewNode.Text.Trim());

                    //根据选择的公司名获取公司ID
                    string iDepartmentId = objOnServiceList.GetDepartmentId(txtParentNode.Text.Trim());

                    if (txtNewNode.Text.Trim() != iDtGroupName)
                    {
                        //封装部门对象
                        Organization objOrg = new Organization()
                        {
                            DtId = Convert.ToInt32(iDepartmentId),
                            DtGroupName = txtNewNode.Text.Trim()
                        };

                        //插入部门数据
                        objOnServiceList.InsertDtGroup(objOrg);

                        //重新生成树型菜单
                        BindTreeView();//重绘方法

                        //输出提示
                        lblInputTips.ForeColor = Color.Green;
                        lblInputTips.Text = "提示：组别名称添加成功！";

                        txtNewNode.Text = null;//清空信息
                        txtParentNode.Text = null;

                        txtParentNode.Focus();
                    }
                    else
                    {
                        //输出提示
                        lblInputTips.ForeColor = Color.Red;
                        lblInputTips.Text = "提示：组别名称重复！请重新输入！";
                        txtNewNode.Text = string.Empty;//清空信息
                        txtNewNode.Focus();
                    }
                }

            }
            else
            {
                //输出提示
                lblInputTips.ForeColor = Color.Red;
                lblInputTips.Text = "提示：你选择的不是部门节点！";
                txtNewNode.Text = string.Empty;//清空信息
                txtNewNode.Focus();
            }

        }

        //修改数据
        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (this.txtParentNode1.Text == "")
            {
                //提示选择节点
                this.lblInputTips1.ForeColor = Color.Red;
                this.lblInputTips1.Text = "请先选择左边的组织节点！";
            }

            //判断输入框是否为空
            else if (this.txtNewNode1.Text == "")
            {
                this.lblInputTips1.ForeColor = Color.Red;
                this.lblInputTips1.Text = "请输入要修改的名称！";
            }

            else if (trvwDepartment.SelectedNode != null)
            {
                if (trvwDepartment.SelectedNode.Level == 0)
                {
                    //验证公司
                    string iNewCyName = objOnServiceList.GetCompanyName(txtNewNode1.Text.Trim());
                    //判断输入的内容是否重复
                    if (iNewCyName == "")
                    {
                        //修改公司
                        objOnServiceList.UpdateCompany(txtNewNode1.Text.Trim(), txtParentNode1.Text.Trim());

                        //重新加载树形菜单
                        BindTreeView();//重绘方法

                        //输出提示
                        lblInputTips1.ForeColor = Color.Green;
                        lblInputTips1.Text = "公司名称修改成功！";

                        txtNewNode1.Text = null;//清空信息
                        txtParentNode1.Text = null;

                        txtParentNode1.Focus();
                    }
                    else
                    {
                        lblInputTips1.ForeColor = Color.Red;
                        lblInputTips1.Text = "公司名称重复！";
                    }
                }
                else if (trvwDepartment.SelectedNode.Level == 1)
                {
                    //验证部门
                    string iNewDtName = objOnServiceList.GetDepartmentName(txtNewNode1.Text.Trim());
                    if (iNewDtName == "")
                    {
                        //修改部门
                        objOnServiceList.UpdateDepartment(txtNewNode1.Text.Trim(), txtParentNode1.Text.Trim());

                        //重新加载树形菜单
                        BindTreeView();//重绘方法

                        //输出提示
                        lblInputTips1.ForeColor = Color.Green;
                        lblInputTips1.Text = "部门名称修改成功！";

                        txtNewNode1.Text = null;//清空信息
                        txtParentNode1.Text = null;

                        txtParentNode1.Focus();
                    }
                    else
                    {
                        lblInputTips1.ForeColor = Color.Red;
                        lblInputTips1.Text = "部门名称重复！";
                    }
                }
                else if (trvwDepartment.SelectedNode.Level == 2)
                {
                    //验证组别
                    string iNewDpName = objOnServiceList.GetDtGroupName(txtNewNode1.Text.Trim());
                    if (iNewDpName == "")
                    {
                        //修改组别
                        objOnServiceList.UpdateDtGroup(txtNewNode1.Text.Trim(), txtParentNode1.Text.Trim());

                        //重新加载树形菜单
                        BindTreeView();//重绘方法

                        //输出提示
                        lblInputTips1.ForeColor = Color.Green;
                        lblInputTips1.Text = "组别名称修改成功！";

                        txtNewNode1.Text = null;//清空信息
                        txtParentNode1.Text = null;

                        txtParentNode1.Focus();
                    }
                    else
                    {
                        lblInputTips1.ForeColor = Color.Red;
                        lblInputTips1.Text = "组别名称重复！";
                    }
                }
            }
        }

        #region 删除数据  需要添加员工信息验证

        //删除数据
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.txtParentNode2.Text == "")
            {
                //提示选择节点
                this.lblInputTips2.ForeColor = Color.Red;
                this.lblInputTips2.Text = "请选择左边的组织节点！";
            }

            //判断是否选择了节点
            else if (trvwDepartment.SelectedNode != null)
            {
                //判断选择的节点是否是公司
                if (trvwDepartment.SelectedNode.Level == 0)
                {
                    //查询节点下是否存在部门信息
                    var iDtNumber = objOnServiceList.GetDepartmentList(txtParentNode2.Text.Trim());
                    //如果节点下没有部门信息则删除公司
                    if (iDtNumber.Count == 0)
                    {
                        //删除公司
                        objOnServiceList.DeleteData("Company", "CompanyName", txtParentNode1.Text.Trim());

                        //重新加载树形菜单
                        BindTreeView();//重绘方法

                        //输出提示
                        lblInputTips2.ForeColor = Color.Green;
                        lblInputTips2.Text = "公司删除成功！";

                        txtParentNode2.Text = null;

                        txtParentNode2.Focus();
                    }
                    else
                    {
                        //重新加载树形菜单
                        BindTreeView();//重绘方法

                        txtParentNode2.Text = null;

                        lblInputTips2.ForeColor = Color.Red;
                        lblInputTips2.Text = "公司下存在数据，不可删除公司！";
                    }
                }

                //判断选择的节点是否是部门
                else if (trvwDepartment.SelectedNode.Level == 1)
                {
                    //查询部门下是否存在组别信息
                    var iDpNumber = objOnServiceList.GetAllGroupList(txtParentNode2.Text.Trim());
                    //如果节点下没有组别信息删除部门
                    if (iDpNumber.Count == 0)
                    {
                        //删除部门
                        objOnServiceList.DeleteData("Department", "DepartmentName", txtParentNode2.Text.Trim());

                        //重新加载树形菜单
                        BindTreeView();//重绘方法

                        //输出提示
                        lblInputTips2.ForeColor = Color.Green;
                        lblInputTips2.Text = "部门删除成功！";

                        txtParentNode2.Text = null;

                        txtParentNode2.Focus();
                    }
                    else
                    {
                        //重新加载树形菜单
                        BindTreeView();//重绘方法

                        txtParentNode2.Text = null;

                        lblInputTips2.ForeColor = Color.Red;
                        lblInputTips2.Text = "部门下存在数据，不可删除部门！";
                    }
                }

                //判断选择的节点是否为组别
                else if (trvwDepartment.SelectedNode.Level == 2)
                {
                    //查询组别下是否存在职位信息
                    var iJobsNumber = objOnServiceList.GetAllJobList(txtParentNode2.Text.Trim());
                    //如果节点下没有职位信息则删除组别
                    if (iJobsNumber.Count == 0)
                    {
                        //删除组别
                        objOnServiceList.DeleteData("DtGroup", "DtGroupName", txtParentNode2.Text.Trim());

                        //重新加载树形菜单
                        BindTreeView();//重绘方法

                        //输出提示
                        lblInputTips2.ForeColor = Color.Green;
                        lblInputTips2.Text = "组别删除成功！";

                        txtParentNode2.Text = null;

                        txtParentNode2.Focus();
                    }
                    else
                    {
                        //重新加载树形菜单
                        BindTreeView();//重绘方法

                        txtParentNode2.Text = null;

                        lblInputTips2.ForeColor = Color.Red;
                        lblInputTips2.Text = "组别下存在数据，不可删除组别！";
                    }
                }
                else
                {
                    lblInputTips2.Text = "选择错误！";
                }
            }
        }

        #endregion


        #region 窗体激活与关闭

        private void FrmAddNode_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmDtManage = null;//当窗体关闭时，将窗体对象清理掉
        }

        #endregion
        
    }
}
