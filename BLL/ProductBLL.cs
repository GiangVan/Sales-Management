using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using DAL;
using System.Drawing;

namespace BLL
{
    public class ProductBLL
    {
        public List<tblProduct> GetProducts()
        {
            ProductDAL dal = new ProductDAL();
            return dal.GetProductsDAL();
        }
        public static void PushDataToListView(ListView lstv)
        {
            ProductDAL products = new ProductDAL();
            ListViewItem product;
            foreach (tblProduct item in products.GetProductsDAL())
            {
                product = lstv.Items.Add(item.ID);
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
        public List<tblProduct> SearchProductBLL(string Descrition)
        {
            ProductDAL dal = new ProductDAL();
            return dal.SearchProductDAL(Descrition);
        }
    }
}
