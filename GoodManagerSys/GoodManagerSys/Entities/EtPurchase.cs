using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Entities {
    class EtPurchase {
        public int PurchaseID { get; set; }
        public int CategoryID { get; set; }
        public string PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public int StaffID { get; set; }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(PurchaseID + "\t");
            sb.Append(CategoryID + "\t");
            sb.Append(PurchaseDate + "\t");
            sb.Append(Quantity + "\t");
            sb.Append(Cost + "\t");
            sb.Append(StaffID + "\t");
            return sb.ToString();
        }
    }
}
