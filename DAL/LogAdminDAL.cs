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
    public class LogAdminDAL:DatabaseService
    {
        public SqlDataReader getLogin(tblAdmin admin)
        {
            string sql = @"select * from tblAdmin where Username like @Username and Password like @Password ";
            SqlParameter parameterUserName = new SqlParameter("@Username", SqlDbType.VarChar);
            parameterUserName.Value = admin.Username;

            SqlParameter parameterPassword = new SqlParameter("@Password", SqlDbType.VarChar);
            parameterPassword.Value = admin.Password;

            SqlDataReader reader = ReadData(sql, new[] { parameterUserName, parameterPassword });
            return reader;
        }
    }
}
