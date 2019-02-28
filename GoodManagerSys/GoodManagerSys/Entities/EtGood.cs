using GoodManagerSys.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Entities
{
    class EtGood
    {
        public int GoodID { get; set; }
        public int CategoryID { get; set; }
        public string ProductionDate { get; set; }
        public string PurchaseDate { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public EState IsValid { get; set; }
    }
}
