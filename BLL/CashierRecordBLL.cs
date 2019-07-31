using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class CashierRecordBLL
    {
        public List<tblCashierRecord> GetAllCash()
        {
            CashierRecordDAL cashrecord = new CashierRecordDAL();
            return cashrecord.getAllCash();
        }
        public List<tblCashierRecord> Search(string descrip)
        {
            CashierRecordDAL dal = new CashierRecordDAL();
            return dal.search(descrip);
        }
    }
}
