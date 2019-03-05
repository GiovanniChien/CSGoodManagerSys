using GoodManagerSys.Enums;
using System.Text;

namespace GoodManagerSys.Entities {
    class EtGood {
        public int GoodID { get; set; }
        public EtCategory Category { get; set; }
        public string ProductionDate { get; set; }
        public string PurchaseDate { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public EState State { get; set; }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(GoodID + "\t");
            sb.Append(Category.ToString() + "\t");
            sb.Append(ProductionDate + "\t");
            sb.Append(PurchaseDate + "\t");
            sb.Append(Cost + "\t");
            sb.Append(Price + "\t");
            sb.Append(State);
            return sb.ToString();
        }
    }
}
