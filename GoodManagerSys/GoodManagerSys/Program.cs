using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodManagerSys;
using GoodManagerSys.Frm;
<<<<<<< HEAD
using GoodManagerSys.Frm.ReportForm;
=======
using GoodManagerSys.Frm.Membership;
>>>>>>> 272d693a5b5c7b2f6947538fd9ce89527e015145
using GoodManagerSys.Frm.Staff;
using GoodManagerSys.UI;

namespace GoodManagerSys
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FrmPurchaseReport());
=======
            Application.Run(new FrmMembership());
>>>>>>> 272d693a5b5c7b2f6947538fd9ce89527e015145
        }
    }
}
