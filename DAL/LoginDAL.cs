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
    public class LoginDAL:DatabaseService
    {
        public SqlDataReader getLogin(tblLogin login)
        {
            string sql = @"select * from tblLogin where Username like @Username and Password like @Password ";
            SqlParameter parameterUserName = new SqlParameter("@Username", SqlDbType.VarChar);
            parameterUserName.Value = login.Username;

            SqlParameter parameterPassword = new SqlParameter("@Password", SqlDbType.VarChar);
            parameterPassword.Value = login.Password;

            SqlDataReader reader =  ReadData(sql,new[] { parameterUserName, parameterPassword} );
            return reader;
        }
        public List<tblLogin> GetUserDAL()
        {
            string sql = @"select * from tblLogin ";
            SqlDataReader reader = ReadData(sql);
            List<tblLogin> user = new List<tblLogin>();
            while (reader.Read())
            {
                string ID = reader.GetString(0);
                string FullName = reader.GetString(1);
                string Age = reader.GetString(2);
                string Address = reader.GetString(3);
                string Contact = reader.GetString(4);
                string Username = reader.GetString(5);
                string Password = reader.GetString(6);
                tblLogin tblLogin = new tblLogin();
                tblLogin.ID = ID;
                tblLogin.FullName = FullName;
                tblLogin.Age = Age;
                tblLogin.Address = Address;
                tblLogin.Contact = Contact;
                tblLogin.Username = Username;
                tblLogin.Password = Password;
                user.Add(tblLogin);
            }
            reader.Close();
            return user;
        }
        public List<tblLogin> SearchUserDAL(string Name)
        {
            string sql = @"select * from tblLogin where FullName like '"+Name+"%'";
            SqlDataReader reader = ReadData(sql);
            List<tblLogin> user = new List<tblLogin>();
            while (reader.Read())
            {
                string ID = reader.GetString(0);
                string FullName = reader.GetString(1);
                string Age = reader.GetString(2);
                string Address = reader.GetString(3);
                string Contact = reader.GetString(4);
                string Username = reader.GetString(5);
                string Password = reader.GetString(6);
                tblLogin tblLogin = new tblLogin();
                tblLogin.ID = ID;
                tblLogin.FullName = FullName;
                tblLogin.Age = Age;
                tblLogin.Address = Address;
                tblLogin.Contact = Contact;
                tblLogin.Username = Username;
                tblLogin.Password = Password;
                user.Add(tblLogin);
            }
            reader.Close();
            return user;
        }

    }
}
