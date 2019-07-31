using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class RemoveLogTrailDAL:DatabaseService
    {
        public List<tblLogTrail> GetTblLogTrails()
        {
            SqlDataReader reader = ReadData("delete from tblLogTrail");
            List<tblLogTrail> dslog = new List<tblLogTrail>();
            while (reader.Read())
            {
                string Dater = reader.GetString(0);
                string Descrip = reader.GetString(1);
                string Authority = reader.GetString(2);

                tblLogTrail log = new tblLogTrail();
                log.Dater = Dater;
                log.Descrip = Descrip;
                log.Authority = Authority;

                dslog.Add(log);
            }
            reader.Close();
            return dslog;
        }
    }
}
