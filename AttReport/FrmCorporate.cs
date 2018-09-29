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
