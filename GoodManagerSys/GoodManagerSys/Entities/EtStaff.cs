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
    }
}
