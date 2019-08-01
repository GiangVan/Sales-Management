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

                ListViewItem product;
                foreach (tblProduct item in ProductBLL.static_GetProducts())
                {
                    product = lstvProduct.Items.Add(item.ID);
                    product.Name = item.ID;
                    product.SubItems.Add(item.Descrip);
                    product.SubItems.Add(item.Price);
                    product.SubItems.Add(item.Type);
                    product.SubItems.Add(item.Size);
                    product.SubItems.Add(item.Brand);
                    product.SubItems.Add(item.Stock);
                    product.SubItems.Add(item.CritLimit);
                    // set product color
                    if (Convert.ToInt32(item.Stock) == 0)
                    {
                        product.ForeColor = Color.Crimson;
                    }
                    else if (Convert.ToInt32(item.Stock) <= Convert.ToInt32(item.CritLimit))
                    {
                        product.ForeColor = Color.Orange;
                    }
                }
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

            txtQuantity.Text = "";
            txtQuantity.Select();
            txtSum.Text = "0.00";
        }

        private void BtnAddtoCart_Click(object sender, EventArgs e)
        {
            if (ProductBLL.DecrementStockOfProduct(txtID.Text, txtQuantity.Text, txtStock.Text))
            {
                // trường hợp chưa có bất kỳ sản phẩm nào trong lstvCart
                if (lstvProduct.Items.Count == 0)
                {
                    AddOneToListViewCart();

                    UpdateBill();
                    ClearAllProductTextBox();
                    txtChange.Text = "0.00";

                    panel2.Show();
                }
                // trường hợp đã có sản phẩm trong lstvCart
                else if (lstvCart.Items.ContainsKey(txtID.Text))
                {
                    ListViewItem item = lstvCart.Items.Find(txtID.Text, true)[0];
                    item.SubItems[3].Text = (Convert.ToInt32(item.SubItems[3].Text) + Convert.ToInt32(txtQuantity.Text)).ToString();
                    item.SubItems[4].Text = (Convert.ToDouble(item.SubItems[4].Text) + Convert.ToDouble(txtSum.Text)).ToString("#,###,##0.00");

                    UpdateBill();
                    txtChange.Text = "0.00";
                }
                // trường hợp chưa có sản phẩm trong lstvCart
                else
                {
                    AddOneToListViewCart();

                    UpdateBill();
                    ClearAllProductTextBox();
                    txtChange.Text = "0.00";
                }
            }
        }
        private void ClearAllProductTextBox()
        {
            txtDesc.Text = "";
            txtPrice.Text = "";
            txtType.Text = "";
            txtQuantity.Text = "";
            txtSum.Text = "";
            txtID.Text = "";
            txtPayment.Text = "";
            txtSize.Text = "";
            txtBrand.Text = "";
            txtStock.Text = "";
        }
        private void AddOneToListViewCart()
        {
            ListViewItem lst = lstvCart.Items.Add(txtID.Text);
            lst.Name = txtID.Text;
            lst.SubItems.Add(txtDesc.Text);//1
            lst.SubItems.Add(txtPrice.Text);
            lst.SubItems.Add(txtQuantity.Text);
            lst.SubItems.Add(txtSum.Text);//4
            lst.SubItems.Add(txtType.Text);
            lst.SubItems.Add(txtSize.Text);
            lst.SubItems.Add(txtBrand.Text);
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            double price = 0;
            double qty = 0;
            double.TryParse(txtPrice.Text, out price);
            double.TryParse(txtQuantity.Text, out qty);
            double SumP = (price * qty);
            txtSum.Text = SumP.ToString("#,###,##0.00");

            if (qty < 0)
            {

                MessageBox.Show("Positive Integers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string productID = lstvCart.FocusedItem.SubItems[0].Text;
                lstvCart.FocusedItem.Remove();
                ProductBLL.SetStockOfProduct(productID, lstvProduct.Items.Find(productID, true)[0].SubItems[6].Text);
                UpdateBill();
            }
            catch (Exception)
            {
                MessageBox.Show("No items to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double UpdateBill()
        {
            double total = 0;
            foreach (ListViewItem item in lstvCart.Items)
            {
                total += double.Parse(item.SubItems[4].Text);
            }
            txtBill.Text = total.ToString("#,###,###0.00");
            return total;
        }

        private void BtnSettle_Click(object sender, EventArgs e)
        {           
            bool result = SaleRecordBLL.AddCash(lstvCart, lblUser.Text, txtPayment.Text, txtBill.Text);
            if (result)
            {
                MessageBox.Show("Successfully saved" + "\nYour Change is: " + txtChange.Text, "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lstvCart.Items.Clear();

                txtBill.Text = "";
                txtChange.Text = "";
                txtPayment.Text = "";
                txtStock.Text = "";
                panel2.Visible = false;
            }
        }
    }
}
