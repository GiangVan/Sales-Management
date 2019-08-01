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
        private void FrmStore_Load(object sender, EventArgs e)
        {
            
            //displaying data from Database to lstview
            try
            {
                // tạo giao diện
                lstvProduct.Items.Clear();
                lstvProduct.Columns.Clear();
                lstvProduct.Columns.Add("Product ID", 0);
                lstvProduct.Columns.Add("Product Name", 210);
                lstvProduct.Columns.Add("Price", 90);
                lstvProduct.Columns.Add("Type", 80);
                lstvProduct.Columns.Add("Size", 80);
                lstvProduct.Columns.Add("Brand", 80);
                lstvProduct.Columns.Add("Stock", 80);
                lstvProduct.Columns.Add("CritLimit", 0);
                // đẩy dữ liệu vào giao diện
                ProductBLL.PushDataToListView(lstvProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            // notthing
        }

        private void LstvProduct_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            txtQuantity.Select();
            txtID.Text = lstvProduct.FocusedItem.Text;
            txtDesc.Text = lstvProduct.FocusedItem.SubItems[1].Text;
            txtPrice.Text = lstvProduct.FocusedItem.SubItems[2].Text;

            txtType.Text = lstvProduct.FocusedItem.SubItems[3].Text;
            txtSize.Text = lstvProduct.FocusedItem.SubItems[4].Text;
            txtBrand.Text = lstvProduct.FocusedItem.SubItems[5].Text;
            txtStock.Text = lstvProduct.FocusedItem.SubItems[6].Text;

            txtQuantity.Text = "0";
            txtQuantity.Focus();
            txtSum.Text = "0.00";
        }

        private void BtnAddtoCart_Click(object sender, EventArgs e)
        {
            CartBLL.AddToListView(panelProduct, lstvCart);
        }
    }
}
