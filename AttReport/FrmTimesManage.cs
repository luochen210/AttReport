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
    public partial class FrmTimesManage : Form
    {
        public FrmTimesManage()
        {
            InitializeComponent();
        }




        #region 窗口关闭时清理对象

        //窗口关闭时清理对象
        private void FrmTimesManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmTimesManage = null;
        }

        #endregion

    }
}
