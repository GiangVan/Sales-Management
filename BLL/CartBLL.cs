using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class CartBLL
    {
        public static void AddToListView(Panel panelProduct, ListView lstv)
        {
            Control txtQuantity = panelProduct.Controls.Find("txtQuantity", true)[0];
            string id = panelProduct.Controls.Find("txtID", true)[0].Text;
            string descrip = panelProduct.Controls.Find("txtDesc", true)[0].Text;
            string price = panelProduct.Controls.Find("txtPrice", true)[0].Text;
            string quantity = txtQuantity.Text;
            string sum = panelProduct.Controls.Find("txtSum", true)[0].Text;
            string type = panelProduct.Controls.Find("txtType", true)[0].Text;
            string size = panelProduct.Controls.Find("txtSize", true)[0].Text;
            string brand = panelProduct.Controls.Find("txtBrand", true)[0].Text;
            string stock = panelProduct.Controls.Find("txtStock", true)[0].Text;

            //ListViewItem item = lstv.Items.Add(id);
            //item.SubItems.Add(descrip);
            //item.SubItems.Add(price);
            //item.SubItems.Add(quantity);
            //item.SubItems.Add(sum);
            //item.SubItems.Add(type);
            //item.SubItems.Add(size);
            //item.SubItems.Add(brand);
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(quantity))
            {
                MessageBox.Show("Please select product from the list OR input Quantity if empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }


            int SaleQty = Convert.ToInt32(quantity);
            double CurrQty = Convert.ToDouble(quantity);
            double CurrStock = Convert.ToDouble(stock);
            if (SaleQty == 0 || CurrStock == 0)
            {
                MessageBox.Show("Quantity or Stock is unavailable!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return;
            }
            else if (CurrStock < 0)
            {
                return;
            }
            else if (CurrQty > CurrStock)
            {
                MessageBox.Show("Limited Stock Available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                decrementStock();
                if (listView2.Items.Count == 0)
                {
                    lst = listView2.Items.Add(txtID.Text);
                    lst.SubItems.Add(txtDesc.Text);
                    lst.SubItems.Add(txtPrice.Text);
                    lst.SubItems.Add(txtQuantity.Text);
                    lst.SubItems.Add(txtSum.Text);
                    lst.SubItems.Add(txtType.Text);
                    lst.SubItems.Add(txtSize.Text);
                    lst.SubItems.Add(txtBrand.Text);



                    double total = Convert.ToDouble(txtSum.Text);
                    Total += total;
                    txtBill.Text = Total.ToString("#,###,###0.00");
                    txtDesc.Text = "";
                    txtPrice.Text = "";

                    txtQuantity.Text = "";
                    txtSum.Text = "";
                    txtID.Text = "";
                    txtType.Text = "";
                    txtBrand.Text = "";
                    txtSize.Text = "";
                    txtStock.Text = "";



                    txtChange.Text = "0.00";

                    panel2.Show();
                    //  groupBox3.Visible = false;

                    return;
                }


                //Updating quantities and Total amount if same ID.
                for (int j = 0; j <= listView2.Items.Count - 1; j++)
                {
                    if (listView2.Items[j].SubItems[0].Text == txtID.Text)
                    {

                        listView2.Items[j].SubItems[3].Text = (Convert.ToInt32(listView2.Items[j].SubItems[3].Text) + Convert.ToInt32(txtQuantity.Text)).ToString();
                        listView2.Items[j].SubItems[4].Text = (Convert.ToDouble(listView2.Items[j].SubItems[4].Text) + Convert.ToDouble(txtSum.Text)).ToString("#,###,##0.00");

                        double tempTotal = Convert.ToDouble(txtSum.Text);

                        txtBill.Text = listView2.Items[j].SubItems[4].Text;

                        Total += tempTotal;
                        txtBill.Text = Total.ToString("#,###,###0.00");

                        txtDesc.Text = "";
                        txtPrice.Text = "";
                        txtType.Text = "";
                        txtQuantity.Text = "";
                        txtSum.Text = "";
                        txtID.Text = "";
                        txtPayment.Text = "";
                        txtSize.Text = "";
                        txtBrand.Text = "";
                        txtChange.Text = "0.00";
                        lblCrit.Text = "0";

                        return;
                    }
                }


                ListViewItem lst2 = new ListViewItem();
                lst2 = listView2.Items.Add(txtID.Text);
                lst2.SubItems.Add(txtDesc.Text);
                lst2.SubItems.Add(txtPrice.Text);
                lst2.SubItems.Add(txtQuantity.Text);
                lst2.SubItems.Add(txtSum.Text);
                lst2.SubItems.Add(txtType.Text);
                lst2.SubItems.Add(txtSize.Text);
                lst2.SubItems.Add(txtBrand.Text);

                double total2 = Convert.ToDouble(txtSum.Text);
                Total += total2;
                txtBill.Text = Total.ToString("#,###,###0.00");

                txtDesc.Text = "";
                txtPrice.Text = "";

                txtType.Text = "";
                txtQuantity.Text = "";
                txtSum.Text = "";
                txtID.Text = "";
                txtPayment.Text = "";
                txtBrand.Text = "";
                txtSize.Text = "";
                txtChange.Text = "0.00";
                txtStock.Text = "";
                lblCrit.Text = "0";

                return;

            }
        }
    }
}
