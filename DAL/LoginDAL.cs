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
        public bool AddUserDAL(tblLogin user)
        {
            string sql = "insert into tblLogin values(@ID, @FullName, @Age, @Address, @Contact, @Username, @Password)";
            SqlParameter parameterID = new SqlParameter("@ID", SqlDbType.NVarChar);
            parameterID.Value = user.ID;
            SqlParameter parameterFullName = new SqlParameter("@FullName", SqlDbType.NVarChar);
            parameterFullName.Value = user.FullName;
            SqlParameter parameterAge = new SqlParameter("@Age", SqlDbType.NVarChar);
            parameterAge.Value = user.Age;
            SqlParameter parameterAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
            parameterAddress.Value = user.Address;
            SqlParameter parameterContact = new SqlParameter("@Contact", SqlDbType.NVarChar);
            parameterContact.Value = user.Contact;
            SqlParameter parameterUsername = new SqlParameter("@Username", SqlDbType.NVarChar);
            parameterUsername.Value = user.Username;
            SqlParameter parameterPassword = new SqlParameter("@Password", SqlDbType.NVarChar);
            parameterPassword.Value = user.Password;
            bool result = WriteData(sql, new[] { parameterID, parameterFullName, parameterAge, parameterAddress, parameterContact, parameterUsername, parameterPassword });
            return result;
        }
        public bool DelUserDAL(string id)
        {
            string del = "delete from tblLogin where ID=@id";
            SqlParameter parID = new SqlParameter("@id", SqlDbType.VarChar);
            parID.Value = id;
            bool kq = WriteData(del, new[] { parID });
            return kq;
        }

        public bool UpUserDAL(tblLogin user)
        {
            string up = "UPDATE tblLogin SET FullName = @fullname ,Age= @age,Address= @address,Contact= @contact,Username= @username,Password= @pass  where  ID = @id";
            SqlParameter parID = new SqlParameter("@id", SqlDbType.VarChar);
            parID.Value = user.ID;
            SqlParameter parFullname = new SqlParameter("@fullname", SqlDbType.VarChar);
            parFullname.Value = user.FullName;
            SqlParameter parAge = new SqlParameter("@age", SqlDbType.VarChar);
            parAge.Value = user.Age;
            SqlParameter parAddress = new SqlParameter("@address", SqlDbType.VarChar);
            parAddress.Value = user.Address;
            SqlParameter parContact = new SqlParameter("@contact", SqlDbType.VarChar);
            parContact.Value = user.Contact;
            SqlParameter parUser = new SqlParameter("@username", SqlDbType.VarChar);
            parUser.Value = user.Username;
            SqlParameter parPass = new SqlParameter("@pass", SqlDbType.VarChar);
            parPass.Value = user.Password;

            bool kq = WriteData(up, new[] { parFullname, parID, parAge, parAddress, parContact, parUser, parPass });
            return kq;
        }
    }
}
