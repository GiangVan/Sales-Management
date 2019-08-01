using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Windows.Forms;
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
        public List<tblRecord> DeleteAllCash()
        {
            SaleRecordDAL saleRecord = new SaleRecordDAL();
            return saleRecord.DeleteAllCash();
        }
        public static bool AddCash(ListView lstvCart, string userID, string payment, string bill)
        {
            SaleRecordDAL saleRecordDAL = new SaleRecordDAL();
            saleRecordDAL.AddCash(lstvCart.Items, userID);
            try
            {
                if (string.IsNullOrWhiteSpace(payment))
                {
                    MessageBox.Show("Enter your Payment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (Convert.ToDouble(bill) > Convert.ToDouble(payment))
                {
                    MessageBox.Show("Insufficient Cash!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //SaleRecordDAL saleRecordDAL = new SaleRecordDAL();
                //saleRecordDAL.AddCash(lstvCart.Items, userID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
