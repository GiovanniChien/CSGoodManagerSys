﻿using GoodManagerSys.Enums;
using System.Text;

namespace GoodManagerSys.Entities {
    class EtStaff {
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string Pwd { get; set; }
        public string StaffPhone { get; set; }
        public ERole Role { get; set; }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(StaffID + "\t");
            sb.Append(StaffName + "\t");
            sb.Append(Pwd + "\t");
            sb.Append(StaffPhone + "\t");
            sb.Append(Role);
            return sb.ToString();
        }
    }
}
