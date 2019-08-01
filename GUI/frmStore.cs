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
    public partial class frmStore : Form
    {
        ListViewItem lst;
        public frmStore()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStart frmStart = new frmStart();
            frmStart.Show();
        }
        public void GetData()
        {
            ProductBLL bll = new ProductBLL();
            List<tblProduct> products = new List<tblProduct>();
            products = bll.GetProducts();
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        private void FrmStore_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
