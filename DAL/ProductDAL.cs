using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class ProductDAL:DatabaseService
    {
        public List<tblProduct> GetProductsDAL()
        {
            string sql = "select * from tblProduct ";
            SqlDataReader reader = ReadData(sql);
            List<tblProduct> products = new List<tblProduct>();
            while (reader.Read())
            {
                string ID = reader.GetString(0);
                string Descrip = reader.GetString(1);
                string Price = reader.GetString(2);
                string Type = reader.GetString(3);
                string Size = reader.GetString(4);
                string Brand = reader.GetString(5);
                string Stock = reader.GetString(6);
                string NetPrice = reader.GetString(7);
                string Manufacturer = reader.GetString(8);
                string CritLimit = reader.GetString(9);
                tblProduct product = new tblProduct();
                product.ID = ID;
                product.Descrip = Descrip;
                product.Price = Price;
                product.Type = Type;
                product.Size = Size;
                product.Brand = Brand;
                product.Stock = Stock;
                product.NetPrice = NetPrice;
                product.Manufacturer = Manufacturer;
                product.CritLimit = CritLimit;
                products.Add(product);
            }
            reader.Close();
            return products;
        }
        public void SetStockOfProduct(string productID, string stock)
        {
            string sql = @"UPDATE tblProduct SET [Stock] = '" + stock + "' where [ID]='" + productID + "'";
            ReadData(sql);
        }
        public List<tblProduct> SearchProductDAL(string Description)
        {
            string sql = "select * from tblProduct where Descrip Like '" + Description + "%'";
            SqlDataReader reader = ReadData(sql);
            List<tblProduct> products = new List<tblProduct>();
            while (reader.Read())
            {
                string ID = reader.GetString(0);
                string Descrip = reader.GetString(1);
                string Price = reader.GetString(2);
                string Type = reader.GetString(3);
                string Size = reader.GetString(4);
                string Brand = reader.GetString(5);
                string Stock = reader.GetString(6);
                string NetPrice = reader.GetString(7);
                string Manufacturer = reader.GetString(8);
                string CritLimit = reader.GetString(9);
                tblProduct product = new tblProduct();
                product.ID = ID;
                product.Descrip = Descrip;
                product.Price = Price;
                product.Type = Type;
                product.Size = Size;
                product.Brand = Brand;
                product.Stock = Stock;
                product.NetPrice = NetPrice;
                product.Manufacturer = Manufacturer;
                product.CritLimit = CritLimit;
                products.Add(product);
            }
            reader.Close();
            return products;
        }
    }
}
