using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Utils
{
    class CalcDateUtil
    {
        public static DateTime NextDays(string productionDate,int expirationDate)
        {
            DateTime dt = new DateTime(
                int.Parse(productionDate.Substring(0, 4)), 
                int.Parse(productionDate.Substring(4, 2)), 
                int.Parse(productionDate.Substring(6, 2))
                );
            DateTime deadline=dt.AddDays(expirationDate);
            return deadline;
        }

        public static int IntervalDays(string productionDate, int expirationDate)
        {
            DateTime deadline = NextDays(productionDate, expirationDate);
            DateTime now = DateTime.Now;
            return DateDiff(deadline, now);
        }

        private static int DateDiff(DateTime deadline, DateTime now)
        {
            DateTime dt1 = Convert.ToDateTime(deadline.ToShortDateString());
            DateTime dt2 = Convert.ToDateTime(now.ToShortDateString());
            TimeSpan sp = dt1.Subtract(dt2);
            return sp.Days;
        }
    }
}
