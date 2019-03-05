using GoodManagerSys.Enums;
using System.Text;

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
            sb.Append(IsValid);
            return sb.ToString();
        }
    }
}
