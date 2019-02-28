using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Entities
{
    class EtMembership
    {
        public int MsID { get; set; }
        public string MsName { get; set; }
        public string MsPhone { get; set; }
        public int MsPoint { get; set; }
        public int isValid { get; set; }
    }
}
