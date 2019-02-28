using GoodManagerSys.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Entities {
    class EtMembership {
        public int MsID { get; set; }
        public string MsName { get; set; }
        public string MsPhone { get; set; }
        public int MsPoint { get; set; }
        public EValid IsValid { get; set; }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(MsID + "\t");
            sb.Append(MsName + "\t");
            sb.Append(MsPhone + "\t");
            sb.Append(MsPoint + "\t");
            sb.Append(IsValid + "\t");
            return sb.ToString();
        }
    }
}
