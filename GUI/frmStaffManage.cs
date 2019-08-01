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
using DTO;

namespace GUI
{
    public partial class frmStaffManage : Form
    {
        public frmStaffManage()
        {
            InitializeComponent();
            timer1.Start();
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

        private void GrdStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow staff = grdStaff.Rows[e.RowIndex];
            txtUserID.Text = staff.Cells[0].Value+"";
            txtFullName.Text = staff.Cells[1].Value + "";
            txtDoB.Text = (DateTime.Now.Year - int.Parse((staff.Cells[2].Value+"").ToString())).ToString();
            txtContact.Text = staff.Cells[4].Value + "";
            txtAddress.Text = staff.Cells[3].Value + "";
            txtUser.Text = staff.Cells[5].Value + "";
            txtPass.Text = staff.Cells[6].Value + "";
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }

        public string generateID()
        {

            var chars = "0923213USERASDASDQ";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 5)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return "USER:" + result;

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                LoginBLL bll = new LoginBLL();
                tblLogin user = new tblLogin();
                txtUserID.Text = generateID();
                user.ID = txtUserID.Text;
                user.FullName = txtFullName.Text;
                user.Age = txtDoB.Text;
                user.Address = txtAddress.Text;
                user.Contact = txtContact.Text;
                user.Username = txtUser.Text;
                user.Password = txtPass.Text;
                bool result = bll.AddUserDAL(user);
                if (result == true)
                {
                    MessageBox.Show("Add new User successful!", "Success", MessageBoxButtons.OK);
                    FrmStaffManage_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Can't Add User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        private void BtnCLear_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtFullName.Text = "";
            txtDoB.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
        }
    }
}
