using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Entities
{
    class EtPurchase
    {
        public int PurchaseID { get; set; }
        public int CategoryID { get; set; }
        public string PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public int staffID { get; set; }
    }
}
