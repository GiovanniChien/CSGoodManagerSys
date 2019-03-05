using GoodManagerSys.Enums;
using System.Text;

namespace GoodManagerSys.Entities {
    class EtCategory {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public ECategory ParentCategoryID { get; set; }
        public string ParentCategoryName { get; set; }
        public string Unit { get; set; }
        public string Color { get; set; }
        public string Firm { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public int ExpirationDate { get; set; }
        public EValid IsValid { get; set; }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(CategoryID + "\t");
            sb.Append(CategoryName + "\t");
            sb.Append(ParentCategoryID + "\t");
            sb.Append(ParentCategoryName + "\t");
            sb.Append(Unit + "\t");
            sb.Append(Color + "\t");
            sb.Append(Firm + "\t");
            sb.Append(MinStock + "\t");
            sb.Append(MaxStock + "\t");
            sb.Append(ExpirationDate + "\t");
            sb.Append(IsValid);
            return sb.ToString();
        }
    }
}
