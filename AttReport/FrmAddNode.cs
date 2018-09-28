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
    public partial class FrmAddNode : Form
    {
        public string nodeName
        {
            get { return txtNodeName.Text.Trim(); }
        }
        public FrmAddNode()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNodeName.Text.Trim()))
            {
                MessageBox.Show("请填写节点名称！");
                return;
            }
            DialogResult = DialogResult.OK;
        }

    }
}
