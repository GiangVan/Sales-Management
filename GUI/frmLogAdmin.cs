using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frmLogAdmin : Form
    {
        public frmLogAdmin()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LogAdminBLL logAdminBLL = new LogAdminBLL();
            tblAdmin admin = new tblAdmin();
            admin.Username = txtUserName.Text;
            admin.Password = txtPassword.Text;
            if (logAdminBLL.getLogin(admin).HasRows)
            {
                tblLogTrail log = new tblLogTrail();
                LogTrailBLL bll = new LogTrailBLL();
                log.Dater = lblDateTime.Text;
                log.Descrip = "User: " + txtUserName.Text + " has successfully Logged In!";
                log.Authority = "Admin";
                bll.Insert(log);
                frmStart frmStart = (frmStart)Application.OpenForms["frmStart"];
                frmStart.Hide();
                frmAdminMenu frmAdminMenu = new frmAdminMenu();
                frmAdminMenu.Show();
                this.Hide();
            }
            else
            {
                DialogResult = MessageBox.Show("Không được phép truy cập! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void FrmLogAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
