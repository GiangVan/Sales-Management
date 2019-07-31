using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class SaleRecordDAL : DatabaseService
    {
        public List<tblRecord> getAllCash()
        {

            SqlDataReader reader = ReadData("select *from tblRecord");
            List<tblRecord> dsSale = new List<tblRecord>();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string descrip = reader.GetString(1);
                string price = reader.GetString(2);
                string quantity = reader.GetString(3);
                string totalsum = reader.GetString(4);
                string type = reader.GetString(5);
                string size = reader.GetString(6);
                string brand = reader.GetString(7);
                DateTime date = reader.GetDateTime(8);
                tblRecord sale = new tblRecord();
                sale.ID = id;
                sale.Description = descrip;
                sale.Price = price;
                sale.Quantity = quantity;
                sale.TotalSum = totalsum;
                sale.Type = type;
                sale.Size = size;
                sale.Brand = brand;
                sale.DateTime = date;
                dsSale.Add(sale);
            }
            reader.Close();
            return dsSale;
        }
        public List<tblRecord> search(string Description)
        {

            SqlDataReader reader = ReadData("Select * from tblRecord where Description like '"+ Description + "%' Order by DateTime DESC");
            List<tblRecord> dsSale = new List<tblRecord>();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string descrip = reader.GetString(1);
                string price = reader.GetString(2);
                string quantity = reader.GetString(3);
                string totalsum = reader.GetString(4);
                string type = reader.GetString(5);
                string size = reader.GetString(6);
                string brand = reader.GetString(7);
                DateTime date = reader.GetDateTime(8);
                tblRecord sale = new tblRecord();
                sale.ID = id;
                sale.Description = descrip;
                sale.Price = price;
                sale.Quantity = quantity;
                sale.TotalSum = totalsum;
                sale.Type = type;
                sale.Size = size;
                sale.Brand = brand;
                sale.DateTime = date;
                dsSale.Add(sale);
            }
            reader.Close();
            return dsSale;
        }
    }
}
