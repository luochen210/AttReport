﻿using System;
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
    public partial class FrmAddStaff : Form
    {
        public FrmAddStaff()
        {
            InitializeComponent();
        }

        private void FrmAddStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmAddStaff = null;//当窗体关闭时，将窗体对象清理掉
        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}