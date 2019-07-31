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
        public List<tblProduct> GetProducts()
        {
            string sql = "select * from tblProduct ";
            SqlDataReader reader = ReadData(sql);
            List<tblProduct> products = new List<tblProduct>();
            while (reader.Read())
            {
                tblProduct product = new tblProduct();
                product.ID = reader.GetString(0);
                product.Descrip = reader.GetString(1);
                product.Price = reader.GetString(2);
                product.Type = reader.GetString(3);
                product.Size = reader.GetString(4);
                product.Brand = reader.GetString(5);
                product.Stock = reader.GetString(6);
                //product.NetPrice = reader.GetString(7);
                //product.Manufacturer = reader.GetString(8);
                product.CritLimit = reader.GetString(7);
                products.Add(product);
            }
            reader.Close();
            return products;
        }
    }
}
