using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frmStaffManage : Form
    {
        public frmStaffManage()
        {
            InitializeComponent();
        }

        private void FrmStaffManage_Load(object sender, EventArgs e)
        {
            LoginBLL bll = new LoginBLL();
            grdStaff.DataSource = bll.GetUserDAL();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoginBLL bll = new LoginBLL();
            grdStaff.DataSource = bll.SearchUserDAL(txtSearch.Text);
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
