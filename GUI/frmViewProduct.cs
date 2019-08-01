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
    public partial class frmViewProduct : Form
    {
        public frmViewProduct()
        {
            InitializeComponent();
        }

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmViewProduct_Load(object sender, EventArgs e)
        {
            ProductBLL bll = new ProductBLL();
            grdProduct.DataSource = ProductBLL.static_GetProducts();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ProductBLL bll = new ProductBLL();
            grdProduct.DataSource = bll.SearchProductBLL(txtSearch.Text);
        }

        private void GrdProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
