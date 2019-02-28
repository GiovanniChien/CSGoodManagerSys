using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Entities
{
    class EtSale
    {
        public int SaleID { get; set; }
        public int GoodID { get; set; }
        public string SaleDate { get; set; }
        public double Profit { get; set; }
        public int StaffID { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(SaleID + "\t");
            sb.Append(GoodID + "\t");
            sb.Append(SaleDate + "\t");
            sb.Append(Profit + "\t");
            sb.Append(StaffID + "\t");
            return sb.ToString();
        }
    }
}
