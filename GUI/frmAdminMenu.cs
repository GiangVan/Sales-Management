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
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void CLoseFormChild(object sender, EventArgs e)
        {
            Form[] childArray = this.MdiChildren;
            foreach (Form childForm in childArray)
            {
                childForm.Close();
            }
        }
        private void LblUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure? ", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                tblLogTrail log = new tblLogTrail();
                LogTrailBLL bll = new LogTrailBLL();
                log.Dater = DateTime.Now.ToString();
                log.Descrip = "User: " + lblUser.Text + " has successfully logged Out!";
                log.Authority = "Admin";
                bll.Insert(log);
                this.Close();
                frmStart frmStart = new frmStart();
                frmStart.Show();
                frmLogAdmin frmLogAdmin = new frmLogAdmin();
                frmLogAdmin.Show();
            }
        }
        private void BtnView_Click(object sender, EventArgs e)
        {
            lbl1.BackColor = Color.SkyBlue;
            lbl2.BackColor = lbl3.BackColor = lbl4.BackColor = lbl5.BackColor = lbl6.BackColor = lbl7.BackColor = Color.White;
            CLoseFormChild(sender, e);
            frmViewProduct frmViewProduct = new frmViewProduct();
            frmViewProduct.MdiParent = this;
            frmViewProduct.Show();
        }

        private void BtnStaffManagement_Click(object sender, EventArgs e)
        {
            lbl2.BackColor = Color.SkyBlue;
            lbl1.BackColor = lbl3.BackColor = lbl4.BackColor = lbl5.BackColor = lbl6.BackColor = lbl7.BackColor = Color.White;
            CLoseFormChild(sender, e);
            frmStaffManage frmStaffManage = new frmStaffManage();
            frmStaffManage.MdiParent = this;
            frmStaffManage.Show();
        }

        private void BtnProductManagement_Click(object sender, EventArgs e)
        {
            lbl3.BackColor = Color.SkyBlue;
            lbl1.BackColor = lbl2.BackColor = lbl4.BackColor = lbl5.BackColor = lbl6.BackColor = lbl7.BackColor = Color.White;
            CLoseFormChild(sender, e);
            frmUpdateAndDelete frmUpdateAndDelete = new frmUpdateAndDelete();
            frmUpdateAndDelete.MdiParent = this;
            frmUpdateAndDelete.Show();
        }

        private void BtnSaleRecord_Click(object sender, EventArgs e)
        {
            lbl4.BackColor = Color.SkyBlue;
            lbl1.BackColor = lbl2.BackColor = lbl3.BackColor = lbl5.BackColor = lbl6.BackColor = lbl7.BackColor = Color.White;
            CLoseFormChild(sender, e);
            frmSaleRecord frmSaleRecord = new frmSaleRecord();
            frmSaleRecord.MdiParent = this;
            frmSaleRecord.Show();
        }

        private void BtnLogRecord_Click(object sender, EventArgs e)
        {
            lbl5.BackColor = Color.SkyBlue;
            lbl1.BackColor = lbl2.BackColor = lbl3.BackColor = lbl4.BackColor = lbl6.BackColor = lbl7.BackColor = Color.White;
            CLoseFormChild(sender, e);
            frmLogTrail frmLogTrail = new frmLogTrail();
            frmLogTrail.MdiParent = this;
            frmLogTrail.Show();
        }

        private void BtnRestock_Click(object sender, EventArgs e)
        {
            lbl6.BackColor = Color.SkyBlue;
            lbl1.BackColor = lbl2.BackColor = lbl3.BackColor = lbl4.BackColor = lbl5.BackColor = lbl7.BackColor = Color.White;
            CLoseFormChild(sender, e);
        }
        private void Panel2_Click(object sender, EventArgs e)
        {
            lbl7.BackColor = Color.SkyBlue;
            lbl1.BackColor = lbl2.BackColor = lbl3.BackColor = lbl4.BackColor = lbl5.BackColor = lbl6.BackColor = Color.White;
            CLoseFormChild(sender, e);
        }
        private void FrmAdminMenu_Load(object sender, EventArgs e)
        {
            panel2.Focus();
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                }
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Silver;
        }
    }
}
