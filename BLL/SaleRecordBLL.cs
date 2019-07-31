using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class SaleRecordBLL
    {
        public List<tblRecord> GetAllCash()
        {
            SaleRecordDAL salerecord = new SaleRecordDAL();
            return salerecord.getAllCash();
        }
        public List<tblRecord> Search(string Description)
        {
            SaleRecordDAL SaleRecord = new SaleRecordDAL();
            return SaleRecord.search(Description);
        }
    }
}
