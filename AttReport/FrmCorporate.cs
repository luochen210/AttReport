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
        }

        private void 员工入职ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 异动记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #region treeView右键菜单

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point ClickPoint = new Point(e.X, e.Y);
                int x = e.X;
                int y = e.Y;
                TreeNode CurrentNode = treeView1.GetNodeAt(ClickPoint);
                if (CurrentNode is TreeNode)//判断你点的是不是一个节点
                {
                    treeView1.SelectedNode = CurrentNode;
                    CurrentNode.ContextMenuStrip = this.contextMenuStrip1;
                    contextMenuStrip1.Show(MousePosition);
                }
                else
                {
                    treeView1.ContextMenuStrip = this.contextMenuStrip2;
                    contextMenuStrip2.Show(MousePosition);
                }
            }
        }

        private void 添加子节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f5 = new Form4();
            if (f5.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Nodes.Add(f5.nodeName);
            }
        }

        private void 删除选中节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void 添加根节点ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            if (f4.ShowDialog() == DialogResult.OK)
            {
                treeView1.Nodes.Add(f4.nodeName);
            }
        }

        private void 清空ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

    #endregion

    #region 窗体激活与关闭

    private void FrmCorporate_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmCorporate = null;//当窗体关闭时，将窗体对象清理掉
        }

        #endregion
    }
}
