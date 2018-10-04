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
            TreeNode CompanyNode, DepartmentNode, DtGroupNode;
            DataSet ds = new DataSet();
            DataTable dtTable = new DataTable();
            DataTable dpTable = new DataTable();
            JobListService objService = new JobListService();

            ds = objService.GetCompanyDS();

            for (int c = 0; c < ds.Tables[0].Rows.Count; c++)
            {
                CompanyNode = new TreeNode(); //创建【公司】根节点对象  
                CompanyNode.Text = ds.Tables[0].Rows[c]["CompanyName"].ToString(); //显示节点的文本  
                CompanyNode.Tag = int.Parse(ds.Tables[0].Rows[c]["CompanyId"].ToString()); //保存对应节点的值  
                trvwCompany.Nodes.Add(CompanyNode);  //将节点填充到树形控件上

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
            this.lblTest.Text = "菜单建立成功！";//测试用控件
        }

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
