using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
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
        public List<tblRecord> DeleteAllCash()
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
        public void AddCash(ListView.ListViewItemCollection collection, string userID)
        {
            string sql = @"INSERT INTO tblRecord([ID],[Description],[Price],[Quantity],[TotalSum],[Type],[Size],[Brand],[DateTime]) VALUES(@row1,@row2,@row3,@row4,@row5,@row6,@row7,@row8,@Date1)";
            connection.Open();
            SqlCommand cm = new SqlCommand(sql, connection);

            foreach (ListViewItem li in collection)
            {
                cm.Parameters.AddWithValue("@row1", li.SubItems[0].Text);
                cm.Parameters.AddWithValue("@row2", li.SubItems[1].Text);
                cm.Parameters.AddWithValue("@row3", li.SubItems[2].Text);
                cm.Parameters.AddWithValue("@row4", li.SubItems[3].Text);
                cm.Parameters.AddWithValue("@row5", li.SubItems[4].Text);
                cm.Parameters.AddWithValue("@row6", li.SubItems[5].Text);
                cm.Parameters.AddWithValue("@row7", li.SubItems[6].Text);
                cm.Parameters.AddWithValue("@row8", li.SubItems[7].Text);
            }
            
            cm.Parameters.AddWithValue("@Date1", DateTime.Now.ToString());
            cm.ExecuteNonQuery(); //ExecuteNonQuery passes a connection string to database or SQL.
            //
            string sql2 = @"INSERT INTO tblCashierRecord([Cashier],[PID],[Descrip],[Price],[Quantity],[TotalSum],[Type],[Size],[Brand],[DateTime]) VALUES(@row1,@row2,@row3,@row4,@row5,@row6,@row7,@row8,@row9,@row10)";
            cm = new SqlCommand(sql2, connection);

            foreach (ListViewItem li in collection)
            {
                cm.Parameters.AddWithValue("@row1", userID);
                cm.Parameters.AddWithValue("@row2", li.SubItems[0].Text);
                cm.Parameters.AddWithValue("@row3", li.SubItems[1].Text);
                cm.Parameters.AddWithValue("@row4", li.SubItems[2].Text);
                cm.Parameters.AddWithValue("@row5", li.SubItems[3].Text);
                cm.Parameters.AddWithValue("@row6", li.SubItems[4].Text);
                cm.Parameters.AddWithValue("@row7", li.SubItems[5].Text);
                cm.Parameters.AddWithValue("@row8", li.SubItems[6].Text);
                cm.Parameters.AddWithValue("@row9", li.SubItems[7].Text);
            }

            cm.Parameters.AddWithValue("@row10", DateTime.Now.ToString());
            cm.ExecuteNonQuery();
        }
    }
}
