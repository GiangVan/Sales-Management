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
    public class CashierRecordDAL:DatabaseService
    {
        public List<tblCashierRecord> getAllCash()
        {

            SqlDataReader reader = ReadData("select *from tblCashierRecord");
            List<tblCashierRecord> dsSale = new List<tblCashierRecord>();
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
                dsSale.Add(sale);
            }
            reader.Close();
            return dsSale;
        }
        public List<tblCashierRecord> search(string Descrip)
        {

            SqlDataReader reader = ReadData("Select * from tblRecord where Description like '" + Descrip + "%' Order by DateTime DESC");
            List<tblCashierRecord> dsSale = new List<tblCashierRecord>();
            while (reader.Read())
            {
                string cashier = reader.GetString(0);
                string id = reader.GetString(1);
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
                sale.PID = id;
                sale.Descrip = descrip;
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
        public List<tblCashierRecord> DeleteAllCashier()
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
