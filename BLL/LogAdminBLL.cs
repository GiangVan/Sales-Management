using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BLL
{
    public class LogAdminBLL
    {
        public SqlDataReader getLogin(tblAdmin admin)
        {
            LogAdminDAL dal = new LogAdminDAL();
            return dal.getLogin(admin);
        }
    }
}
