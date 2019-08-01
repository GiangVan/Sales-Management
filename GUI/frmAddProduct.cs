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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void CboManufac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddManufac frmAddManufac = new frmAddManufac();
            frmAddManufac.Show();
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            ProductBLL bll = new ProductBLL();
            grdProduct.DataSource = bll.GetProducts();
        }
    }
}
