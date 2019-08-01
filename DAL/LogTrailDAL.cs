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
            SqlDataReader reader = ReadData("select * from tblLogTrail order by Dater desc");
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
        public bool Insert(tblLogTrail log)
        {
            //tương tác csdl để thêm mới
            string sql  = @"INSERT INTO tblLogTrail VALUES(@Dater,@Description,@Authority)";
            SqlParameter parDater = new SqlParameter("@Dater", SqlDbType.VarChar);
            parDater.Value = log.Dater;
            SqlParameter parDes = new SqlParameter("@Description", SqlDbType.VarChar);
            parDes.Value = log.Descrip;
            SqlParameter parAuth = new SqlParameter("@Authority", SqlDbType.VarChar);
            parAuth.Value = log.Authority;
            bool kq = WriteData(sql, new[] { parDater, parDes, parAuth });
            return kq;
        }
        public List<tblLogTrail> RemoveLogTrailsDAL()
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
