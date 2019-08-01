using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class AddManufacDAL:DatabaseService
    {
        public bool InsertManufac(tblManufacturer manufac)
        {
            string sql = "insert into tblManufacturer values(@id,@name)";
            SqlParameter parid = new SqlParameter("@id", SqlDbType.VarChar);
            parid.Value = manufac.ID;
            SqlParameter parname = new SqlParameter("@name", SqlDbType.VarChar);
            parname.Value = manufac.MName;
            bool ret = WriteData(sql, new[] { parid, parname });
            return ret;
        }
    }
}
