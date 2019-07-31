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
    public class RemoveAllDAL:DatabaseService
    {
        public List<tblRecord> getAllCash()
        {
            SqlDataReader reader = ReadData("delete from tblRecord");
            List<tblRecord> dsSaleRe = new List<tblRecord>();
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
                dsSaleRe.Add(sale);
            }
            reader.Close();
            return dsSaleRe;
        }
        public List<tblCashierRecord> getAllCashier()
        {
            SqlDataReader reader = ReadData("delete from tblCashierRecord");
            List<tblCashierRecord> dsSaleRe = new List<tblCashierRecord>();
            while (reader.Read())
            {
                string cashier = reader.GetString(0);
                string pid = reader.GetString(1);
                string descrip = reader.GetString(2);
                string price = reader.GetString(3);
                string quantity = reader.GetString(4);
                string totalsum = reader.GetString(5);
                string type = reader.GetString(6);
                string size = reader.GetString(7);
                string brand = reader.GetString(8);
                DateTime date = reader.GetDateTime(9);
                tblCashierRecord sale = new tblCashierRecord();
                sale.Cashier = cashier;
                sale.PID = pid;
                sale.Descrip = descrip;
                sale.Price = price;
                sale.Quantity = quantity;
                sale.TotalSum = totalsum;
                sale.Type = type;
                sale.Size = size;
                sale.Brand = brand;
                sale.DateTime = date;
                dsSaleRe.Add(sale);
            }
            reader.Close();
            return dsSaleRe;
        }
    }
}
