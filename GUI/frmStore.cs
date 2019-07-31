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
                lstProduct.Items.Clear();
                lstProduct.Columns.Clear();
                lstProduct.Columns.Add("Product ID", 0);
                lstProduct.Columns.Add("Product Name", 150);

                lstProduct.Columns.Add("Price", 70);
                lstProduct.Columns.Add("Type", 70);
                lstProduct.Columns.Add("Size", 70);
                lstProduct.Columns.Add("Brand", 70);
                lstProduct.Columns.Add("Stock", 70);
                lstProduct.Columns.Add("CritLimit", 0);
                while (products != null)
                {
                    lst = lstProduct.Items.Add(products[0].ToString());
                    lst.SubItems.Add(products[1].ToString());
                    lst.SubItems.Add(products[2].ToString());
                    lst.SubItems.Add(products[3].ToString());
                    lst.SubItems.Add(products[4].ToString());
                    lst.SubItems.Add(products[5].ToString());
                    lst.SubItems.Add(products[6].ToString());
                    //lst.SubItems.Add(products[9].ToString());
                    //if (int.Parse(products[6].ToString()) == 0)
                    //{

                    //    lst.ForeColor = Color.Crimson;


                    //}
                    //else if (int.Parse(products[6].ToString()) <= int.Parse(products[9].ToString()))
                    //{
                    //    lst.ForeColor = Color.Orange;
                    //}
                }
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
