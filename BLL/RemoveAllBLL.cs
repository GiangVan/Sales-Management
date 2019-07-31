using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class RemoveAllBLL
    {
        public List<tblRecord> GetAllCash()
        {
            RemoveAllDAL salerecord = new RemoveAllDAL();
            return salerecord.getAllCash();
        }
        public List<tblCashierRecord> GetAllCashier()
        {
            RemoveAllDAL dal = new RemoveAllDAL();
            return dal.getAllCashier();
        }
    }
}
