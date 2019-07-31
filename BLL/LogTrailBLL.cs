using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using DTO;
namespace BLL
{
    public class LogTrailBLL
    {
        public List<tblLogTrail> GetTblLogTrails()
        {
            LogTrailDAL dal = new LogTrailDAL();
            return dal.GetTblLogTrails();
        }
       
    }
    
}
