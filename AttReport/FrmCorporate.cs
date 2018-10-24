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
        }

        //启动加载
        private void FrmCorporate_Load(object sender, EventArgs e)
        {
            //创建菜单
            BindTreeView();

            //展开目录
            if (this.trvwCompany.SelectedNode != null)
            {
                this.trvwCompany.Nodes[0].Expand();//展开一级目录
            }
        }

        int nodeNumber = 0;//记数变量

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
            if (trvwCompany.Nodes.Count <= 0)
            {
                trvwCompany.Nodes.Add("请修改为公司名");
            }
        }

        #endregion

        #region treeView右键菜单事件

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

        #region 重命节点
        private void trvwCompany_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            JobListService objService = new JobListService();

            //e.Node.EndEdit(false);

            if (trvwCompany.SelectedNode.Level == 0 && e.Label != null) 
            {
                objService.UpdateCompany(e.Label, e.Node.Text);
            }
            else if (trvwCompany.SelectedNode.Level == 1 && e.Label != null)
            {
                objService.UpdateDepartment(e.Label, e.Node.Text);
            }
            else if (trvwCompany.SelectedNode.Level == 2 && e.Label != null)
            {
                objService.UpdateDtGroup(e.Label, e.Node.Text);
            }
            trvwCompany.EndUpdate();
        }
        #endregion

        #region 右键菜单

        private void 修改节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trvwCompany.LabelEdit = true;
            trvwCompany.SelectedNode.BeginEdit();
        }

        private void 增加节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nodeNumber++;

            //JobListService objService = new JobListService();
            //if (trvwCompany.SelectedNode.Level == 0)
            //{
            //    //选定节点
            //    trvwCompany.SelectedNode = trvwCompany.Nodes.Add("请修改节点名称"+ nodeNumber);

            //    JobList objJobList = new JobList()
            //    {
            //        CompanyName = trvwCompany.SelectedNode.Text
            //    };

            //    objService.InsertCompany(objJobList);
            //}
            //else if (trvwCompany.SelectedNode.Level == 1)
            //{
            //    //选定节点
            //    trvwCompany.SelectedNode = trvwCompany.SelectedNode.Nodes.Add("请修改节点名称"+ nodeNumber);

            //    JobList objJobList = new JobList()
            //    {
            //        DepartmentName = trvwCompany.SelectedNode.Text
            //    };

            //    objService.InsertDepartment(objJobList);
            //}
            //else if (trvwCompany.SelectedNode.Level == 2)
            //{
            //    //选定节点
            //    trvwCompany.SelectedNode = trvwCompany.SelectedNode.Nodes.Add("请修改节点名称" + nodeNumber);

            //    JobList objJobList = new JobList()
            //    {
            //        DtGroupName = trvwCompany.SelectedNode.Text
            //    };

            //    objService.InsertDtGroup(objJobList);
            //}

            //修改节点
            trvwCompany.LabelEdit = true;
            trvwCompany.SelectedNode.BeginEdit();
        }

        private void 删除节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobListService objService = new JobListService();
            if (trvwCompany.SelectedNode == null)
            {
                MessageBox.Show("请选择要删除的节点！");
                return;
            }
            else
            {
                trvwCompany.SelectedNode.Remove();//删除节点
            }
            
            //删除数据表            
            if (trvwCompany.SelectedNode.Level == 0)
            {
                
                objService.DeleteNode("Company", "CompanyName",trvwCompany.SelectedNode.Text.Trim());
            }
            else if (trvwCompany.SelectedNode.Level == 1)
            {
                objService.DeleteNode("Department", "DepartmentName", trvwCompany.SelectedNode.Text.Trim());
            }
            else if (trvwCompany.SelectedNode.Level == 2)
            {
                objService.DeleteNode("DtGroup", "DtGroupName", trvwCompany.SelectedNode.Text.Trim());
            }
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

    }
}
