using GoodManagerSys.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(CategoryID + " ");
            sb.Append(CategoryName + " ");
            sb.Append(ParentCategoryID + " ");
            sb.Append(ParentCategoryName + " ");
            sb.Append(Unit + " ");
            sb.Append(Color + " ");
            sb.Append(Firm + " ");
            sb.Append(MinStock + " ");
            sb.Append(MaxStock + " ");
            sb.Append(ExpirationDate + " ");
            sb.Append(IsValid);
            return sb.ToString();
        }
    }
}
