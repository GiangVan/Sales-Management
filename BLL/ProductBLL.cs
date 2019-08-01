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
            return dal.GetProductsDAL();
        }

        public List<tblProduct> SearchProductBLL(string Descrition)
        {
            ProductDAL dal = new ProductDAL();
            return dal.SearchProductDAL(Descrition);
        }
        public bool Delete(string id)
        {
            ProductDAL dal = new ProductDAL();
            return dal.Delete(id);
        }
        public bool Delete(tblProduct product)
        {
            return Delete(product.ID);
        }
        public bool Update(tblProduct product)
        {
            return new ProductDAL().Update(product);
        }
    }
}
