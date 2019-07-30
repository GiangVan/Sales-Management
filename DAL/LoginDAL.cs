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
    }
}
