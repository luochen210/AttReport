using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using System.Data.SqlClient;

namespace AttReport
{
    public partial class FrmCorporate : Form
    {
        public FrmCorporate()
        {
            InitializeComponent();

            if (this.trvwCompany.SelectedNode != null)
            {
                this.trvwCompany.Nodes[0].Expand();//将递归树一级目录展开
            }


        }

        //启动加载
        private void FrmCorporate_Load(object sender, EventArgs e)
        {
            BindTreeView();
        }

        #region treeView右键菜单

        private void trvwCompany_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)//treeView控件的NodeMouseClick事件
        {
            if (e.Button == MouseButtons.Right)//判断鼠标按键是否为右键
            {
                //获取鼠标右键点击位置
                Point pos = new Point(e.Node.Bounds.X + e.Node.Bounds.Width, e.Node.Bounds.Y + e.Node.Bounds.Height);

                this.trvwCompany.SelectedNode = e.Node;//右键选中节点
                this.cmsCompany.Show(this.trvwCompany, pos);//展示右键菜单
            }
        }

        #endregion

        #region 创建TreeNode  //待修改实现功能的代码

        //待修改代码
        private void InitializeTreeView()
        {
            this.trvwCompany.BeginUpdate();
            this.trvwCompany.Nodes.Add("CompanyNode");
            this.trvwCompany.Nodes[0].Nodes.Add("DepartmentNode");
            this.trvwCompany.Nodes[0].Nodes.Add("Child 2");
            this.trvwCompany.Nodes[0].Nodes[1].Nodes.Add("WorkGroupNode");
            this.trvwCompany.EndUpdate();
        }

        //待修改代码
        private void BindTreeView()
        {
            TreeNode CompanyNode, DepartmentNode, WorkGroupNode;
            DataSet ds = new DataSet();
            DataTable table = new DataTable();
            DataTable districtidTable = new DataTable();

            string cySql = "select CompanyId, CompanyName from Company";
            string dtSql = "select DepartmentId, DepartmentName from Department where CyId = (select CompanyId from Company where CompanyName = '{0}')";

            this.lblTest.Text = "没有设置测试值";

            string wpSql = "select * from DtGroup";

            ds = SQLHelper.GetDataSet(cySql);


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                CompanyNode = new TreeNode(); //创建【公司】根节点对象  
                CompanyNode.Text = ds.Tables[0].Rows[i]["CompanyName"].ToString(); //显示节点的文本  
                CompanyNode.Tag = int.Parse(ds.Tables[0].Rows[i]["CompanyId"].ToString()); //保存对应节点的值  
                trvwCompany.Nodes.Add(CompanyNode);  //将节点填充到树形控件上

                SqlParameter[] parameters = {
                            new SqlParameter("@CompanyId", SqlDbType.Int ,4) ,
                        };
                // 设置参数类型 
                parameters[0].Value = int.Parse(ds.Tables[0].Rows[i]["CompanyId"].ToString());


                table = SQLHelper.GetDataSet(dtSql).Tables[0];
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    DepartmentNode = new TreeNode(); //创建【部门】节点  
                    DepartmentNode.Text = table.Rows[j]["DepartmentName"].ToString(); //显示节点的文本  

                    DepartmentNode.Tag = int.Parse(table.Rows[j]["DepartmentId"].ToString());//显示节点对应的值  
                    CompanyNode.Nodes.Add(DepartmentNode); //将节点绑定到【公司】中


                    SqlParameter[] district = {
                                    new SqlParameter("@DepartmentId", SqlDbType.Int ,4) ,
                            };
                    // 设置参数类型 
                    district[0].Value = int.Parse(table.Rows[j]["DepartmentId"].ToString());
                    districtidTable = SQLHelper.GetDataSet(wpSql).Tables[0];
                    for (int n = 0; n < districtidTable.Rows.Count; n++)
                    {
                        WorkGroupNode = new TreeNode(); //创建【组别】节点  
                        WorkGroupNode.Text = districtidTable.Rows[n]["DtGroupName"].ToString(); //显示节点的文本  
                        WorkGroupNode.Tag = int.Parse(districtidTable.Rows[n]["DtGroupId"].ToString()); //显示节点对应的值  
                        DepartmentNode.Nodes.Add(WorkGroupNode); //将该节点填充到【部门】节点中
                    }
                }
            }
        }

        #region 新方法待修改
        
        //一.创建方法
        /// <summary>
        /// 填充数据
        /// </summary>
        /// <param name="ds">绑定数据</param>
        /// <param name="tableName">表名</param>
        /// <param name="strSql">SQL查寻语句参数</param>
        public void FillData(DataSet ds, string tableName, string strSql)
        {
            ds.Clear();
            SqlConnection conn = new SqlConnection(SQLHelper.ConnectionString.ToString());
            conn.Open();
            SqlDataAdapter myAdapter = new SqlDataAdapter(strSql, conn);
            myAdapter.Fill(ds, tableName);
        }
        //二..绑定树

        /// <summary>
        /// 建立目录、模块、功能树
        /// </summary>
        /// <param name="tvCatModFunTree">TreeView的对象</param>
        public void InitTree(TreeView tvCatModFunTree)
        {
            //填充数据集:dsCatalogManager
            DataSet dsCatalogManager = new DataSet();
            string strSqlCatalogManager = "select CatalogId,CatalogName from CatalogManager where Active='Y' order by CatalogId";
            FillData(dsCatalogManager, "CatalogManager", strSqlCatalogManager);
            if (dsCatalogManager.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsCatalogManager.Tables[0].Rows.Count; i++)
                {
                    //把目录表绑定到根节点,作为第一级节点
                    TreeNode tnCatalogManager = new TreeNode();
                    tnCatalogManager.Value = dsCatalogManager.Tables[0].Rows[i]["CatalogId"].ToString();
                    tnCatalogManager.Text = dsCatalogManager.Tables[0].Rows[i]["CatalogName"].ToString();
                    tnCatalogManager.SelectAction = TreeNodeSelectAction.None;//选定节点,事件为空
                                                                              //填充数据集:dsModuleManager
                    DataSet dsModuleManager = new DataSet();
                    string strSqlModuleManager = "select  ModuleID,ModuleName,CatalogID from  ModuleManager where Active='Y' and  catalogid='" + dsCatalogManager.Tables[0].Rows[i][0].ToString().Trim() + "' order by ModuleID ";
                    FillData(dsModuleManager, "ModuleManager", strSqlModuleManager);
                    if (dsModuleManager.Tables[0].Rows.Count > 0)
                    {
                        for (int j = 0; j < dsModuleManager.Tables[0].Rows.Count; j++)
                        {
                            //把模块表绑定到子节点,作为第二级节点
                            TreeNode tnModuleName = new TreeNode();
                            tnModuleName.Value = dsModuleManager.Tables[0].Rows[j]["ModuleID"].ToString();
                            tnModuleName.Text = dsModuleManager.Tables[0].Rows[j]["ModuleName"].ToString();
                            tnModuleName.SelectAction = TreeNodeSelectAction.None;  //选定节点,事件为空         
                                                                                    //填充数据集:dsFunctionManager
                            DataSet dsFunctionManager = new DataSet();
                            string strSqlFunctionManager = "select  FunctionID,FunctionName,ModuleID from  FunctionManager where Active='Y' and ModuleID='"
                                                           + dsModuleManager.Tables[0].Rows[j][0].ToString().Trim() + "' order by FunctionID  ";
                            FillData(dsFunctionManager, "FunctionManager", strSqlFunctionManager);
                            if (dsFunctionManager.Tables[0].Rows.Count > 0)
                            {
                                for (int k = 0; k < dsFunctionManager.Tables[0].Rows.Count; k++)
                                {
                                    //把功能表绑定到叶子节点,作为第三级节点
                                    TreeNode tnFunctionName = new TreeNode();
                                    tnFunctionName.Value = dsFunctionManager.Tables[0].Rows[k]["FunctionID"].ToString();
                                    tnFunctionName.Text = dsFunctionManager.Tables[0].Rows[k]["FunctionName"].ToString();
                                    tnFunctionName.Selected = false;
                                    tnFunctionName.SelectAction = TreeNodeSelectAction.None;//选定节点,事件为空
                                                                                            //把功能名称绑定到模块功能名称下，作为尾节点                                       
                                    tnModuleName.ChildNodes.Add(tnFunctionName);
                                }
                            }
                            //把模块名称绑定到目录名称下，作为子节点
                            tnModuleName.ExpandAll();
                            tnCatalogManager.ChildNodes.Add(tnModuleName);
                        }
                    }
                    // 把目录名称绑定到TreeView控件，作为父节点
                    tnCatalogManager.ExpandAll();
                    tvCatModFunTree.Nodes.Add(tnCatalogManager);
                }
            }
        }

        #endregion

        #endregion


        private void 员工入职ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 异动记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #region 窗体激活与关闭

        private void FrmCorporate_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmCorporate = null;//当窗体关闭时，将窗体对象清理掉
        }

        #endregion

        private void 修改公司ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 增加公司ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 删除公司ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
