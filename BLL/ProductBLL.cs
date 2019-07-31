using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ProductBLL
    {
        public List<tblProduct> GetProducts()
        {
            ProductDAL dal = new ProductDAL();
            return dal.GetProducts();
        }
    }
}
