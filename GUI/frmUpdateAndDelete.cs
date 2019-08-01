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
    public partial class frmUpdateAndDelete : Form
    {
        public frmUpdateAndDelete()
        {
            InitializeComponent();
        }

        private void FrmUpdateAndDelete_Load(object sender, EventArgs e)
        {
            ProductBLL bll = new ProductBLL();
            gvProduct.DataSource = bll.GetProducts();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ProductBLL bll = new ProductBLL();
            
            bool ret = bll.Delete(txtProductID.Text);

            if (ret)
            {

                gvProduct.DataSource = bll.GetProducts();
                MessageBox.Show("Deleted successfully");
            }
            else
            {
                MessageBox.Show("Delete failure");
            }
            
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            tblProduct product = new tblProduct();
            product.ID = txtProductID.Text;
            product.Descrip = txtProductName.Text;
            product.Price = txtPrice.Text;
            ProductBLL bll = new ProductBLL();
            
            bool ret = bll.Update(product);
            if (ret)
            {
                gvProduct.DataSource = bll.GetProducts();
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Update failure");
            }
            
        }

        private void GvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = gvProduct.Rows[e.RowIndex];
            txtProductID.Text = row.Cells[0].Value + "";
            txtProductName.Text = row.Cells[1].Value + "";
            txtPrice.Text = row.Cells[2].Value + "";
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ProductBLL bll = new ProductBLL();
            gvProduct.DataSource = bll.SearchProductBLL(txtSearch.Text);
        }
    }
}
