using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class LogTrailDAL:DatabaseService
    {
        public List<tblLogTrail> GetTblLogTrails()
        {
            SqlDataReader reader = ReadData("select * from tblLogTrail");
            List<tblLogTrail> dsLogTrail = new List<tblLogTrail>();
            while (reader.Read())
            {
                string Dater = reader.GetString(0);
                string Descrip = reader.GetString(1);
                string Authority = reader.GetString(2);
                tblLogTrail lh = new tblLogTrail();
                lh.Dater = Dater;
                lh.Descrip = Descrip;
                lh.Authority = Authority;
                dsLogTrail.Add(lh);
            }
            reader.Close();
            return dsLogTrail;
        }
       
    }
}
