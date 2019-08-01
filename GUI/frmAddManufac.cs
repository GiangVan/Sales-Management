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
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmAddManufac : Form
    {
        public frmAddManufac()
        {
            InitializeComponent();
        }

        private void FrmAddManufac_Load(object sender, EventArgs e)
        {
            LoginBLL log = new LoginBLL();
            
        }
        public void generateID()
        {

            var chars = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 5)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            txtID.Text = "MID:" + result;

        }
        public void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="")
            {
                MessageBox.Show("Fill textboxes to process.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                try
                {
                    AddManufacturerBLL bll = new AddManufacturerBLL();
                    tblManufacturer manufac = new tblManufacturer();
                    manufac.MName = txtName.Text;
                    generateID();
                    manufac.ID = txtID.Text;
                    bool ret = bll.InsertManufac(manufac);
                    if (ret==true)
                    {
                        MessageBox.Show("Inserted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Insert failure");        
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Re-input again. Your Company may already be added to database!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
