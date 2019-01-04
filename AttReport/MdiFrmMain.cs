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
    public partial class MdiFrmMain : Form
    {
        public MdiFrmMain()
        {
            InitializeComponent();
        }

        private void MdiFrmMain_Load(object sender, EventArgs e)
        {
            Form[] formList = this.MdiChildren;
            foreach (Form frm in formList)
            {
                frm.Close();
            }
            FrmMain objFrm = new FrmMain();
            //窗体最大化
            objFrm.WindowState = FormWindowState.Maximized;

            ////去掉边框
            //frm.FormBorderStyle = FormBorderStyle.None;

            objFrm.MdiParent = this;

            //////设置新窗体的Parent
            //frm.Parent = panel1;
            //frm.Dock = Dock;

            objFrm.Show();
        }
    }
}
