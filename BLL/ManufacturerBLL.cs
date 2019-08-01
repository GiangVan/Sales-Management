using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL
{
    public class AddManufacturerBLL
    {
        public bool InsertManufac(tblManufacturer manufac)
        {
            AddManufacDAL dal = new AddManufacDAL();
            return dal.InsertManufac(manufac);
        }

    }
}
