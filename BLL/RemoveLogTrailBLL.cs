using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class RemoveLogTrailBLL
    {
        public List<tblLogTrail> GetTblLogTrails()
        {
            RemoveLogTrailDAL salerecord = new RemoveLogTrailDAL();
            return salerecord.GetTblLogTrails();
        }
    }
}
