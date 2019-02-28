using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Entities
{
    class EtStaff
    {
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string Pwd { get; set; }
        public string StaffPhone { get; set; }
        public int Role { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(StaffID + "\t");
            sb.Append(StaffName + "\t");
            sb.Append(Pwd + "\t");
            sb.Append(StaffPhone + "\t");
            sb.Append(Role + "\t");
            return sb.ToString();
        }
    }
}
