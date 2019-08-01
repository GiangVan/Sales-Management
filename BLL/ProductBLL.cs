using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using DAL;

namespace BLL
{
    public class ProductBLL
    {
        public List<tblProduct> GetProducts()
        {
            ProductDAL dal = new ProductDAL();
            return dal.GetProductsDAL();
        }
        public static List<tblProduct> static_GetProducts()
        {
            ProductDAL dal = new ProductDAL();
            return dal.GetProductsDAL();
        }
        public static void SetStockOfProduct(string productID, string stock)
        {
            ProductDAL productDAL = new ProductDAL();
            productDAL.SetStockOfProduct(productID, stock.ToString());
        }
        public static bool DecrementStockOfProduct(string productID, string quantity, string stock)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(productID) || string.IsNullOrWhiteSpace(quantity))
                {
                    MessageBox.Show("Please select product from the list OR input Quantity if empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                double currQty = Convert.ToDouble(quantity);
                double currStock = Convert.ToDouble(stock);
                double finStock = currStock - currQty;

                if (currQty == 0 || currStock == 0)
                {
                    MessageBox.Show("Quantity or Stock is unavailable!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (currStock < 0)
                {
                    return false;
                }
                else if (currQty > currStock)
                {
                    MessageBox.Show("Limited Stock Available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    SetStockOfProduct(productID, finStock.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No Items to Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public List<tblProduct> SearchProductBLL(string Descrition)
        {
            ProductDAL dal = new ProductDAL();
            return dal.SearchProductDAL(Descrition);
        }
    }
}
