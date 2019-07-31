using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblCashierRecord
    {
        public string Cashier { get; set; }
        public string PID { get; set; }
        public string Descrip { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string TotalSum { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string Brand { get; set; }
        public DateTime DateTime { get; set; }
    }
}
