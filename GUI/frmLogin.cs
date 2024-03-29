﻿using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginBLL loginBLL = new LoginBLL();
            tblLogin login = new tblLogin();
            login.Username = txtUserName.Text;
            login.Password = txtPassword.Text;
            if (loginBLL.getLogin(login).HasRows)
            {
                tblLogTrail log = new tblLogTrail();
                LogTrailBLL bll = new LogTrailBLL();
                log.Dater = lblDateTime.Text;
                log.Descrip = "User: " + txtUserName.Text + " has successfully Logged In!";
                log.Authority = "Cashier";
                bll.Insert(log);
                frmStart frmStart = (frmStart)Application.OpenForms["frmStart"];
                frmStart.Hide();
                frmStore frmStore = new frmStore();
                frmStore.Show();
                this.Hide();
            }
            else
            {
                DialogResult = MessageBox.Show("Khôngg được phép truy cập! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }
    }
}
