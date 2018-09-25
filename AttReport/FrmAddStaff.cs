using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace AttReport
{
    public partial class FrmAddStaff : Form
    {
        JobListService objJobListService = new JobListService();
        public FrmAddStaff()
        {
            InitializeComponent();

            this.cboDepartment.DataSource = objJobListService.GetAllDepartment();
            this.cboDepartment.DisplayMember = "DepartmentName";
            this.cboDepartment.ValueMember = "DepartmentID";
            this.cboDepartment.SelectedIndex = -1;//默认不选中

        }

        private void FrmAddStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmAddStaff = null;//当窗体关闭时，将窗体对象清理掉
        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {

        }
    }
}
