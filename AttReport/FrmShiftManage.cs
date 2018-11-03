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
    public partial class FrmShiftManage : Form
    {
        public FrmShiftManage()
        {
            InitializeComponent();
        }

        private void btnClassesAdd_Click(object sender, EventArgs e)
        {


        }





        #region 窗口关闭时清理对象

        //窗口关闭时清理对象
        private void FrmShiftManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmShiftManage = null;
        }

        #endregion


    }
}
