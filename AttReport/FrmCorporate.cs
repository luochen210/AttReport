using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttReport
{
    public partial class FrmCorporate : Form
    {
        public FrmCorporate()
        {
            InitializeComponent();

            this.trvwCompany.Nodes[0].Expand();//将递归树一级目录展开
        }

        private void 员工入职ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 异动记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #region treeView右键菜单

        private void trvwCompany_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point pos = new Point(e.Node.Bounds.X + e.Node.Bounds.Width, e.Node.Bounds.Y + e.Node.Bounds.Height / 2);

                this.trvwCompany.SelectedNode = e.Node;//右键选中节点
                this.cmsCompany.Show(this.trvwCompany, pos);//展示右键菜单

            }
        }

        #endregion

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
