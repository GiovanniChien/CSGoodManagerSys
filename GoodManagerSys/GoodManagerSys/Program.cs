﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodManagerSys;
using GoodManagerSys.Frm;
using GoodManagerSys.Frm.Membership;
using GoodManagerSys.Frm.Sale;
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
            Application.Run(new FrmSaleQuery());
        }
    }
}
