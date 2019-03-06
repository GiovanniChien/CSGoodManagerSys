using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Category {
    public partial class FrmCategoryInsert : Form {
        public FrmCategoryInsert() {
            InitializeComponent();
            CmbParentCategoryName.SelectedIndex = 0;
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            try {
                string CategoryName = TxtCategoryName.Text;
                ECategory ParentCategoryEnum = (ECategory)CmbParentCategoryName.SelectedIndex;
                string ParentCategoryName = ParentCategoryEnum.ToString();
                Console.WriteLine(ParentCategoryName);
                string Firm = TxtFirm.Text;
                string Unit = TxtUnit.Text;
                string Color = TxtColor.Text;
                int ExpirationDate = int.Parse(TxtExpirationDate.Text);
                int MinStock = int.Parse(TxtMinStock.Text);
                int MaxStock = int.Parse(TxtMaxStock.Text);
                EtCategory category = new EtCategory {
                    CategoryName = CategoryName,
                    ParentCategoryID = ParentCategoryEnum,
                    ParentCategoryName = ParentCategoryName,
                    Unit = Unit,
                    Color = Color,
                    Firm = Firm,
                    MinStock = MinStock,
                    MaxStock = MaxStock,
                    ExpirationDate = ExpirationDate,
                    IsValid = EValid.有效
                };
                CategoryDao.InsertCategory(category);
                Close();
            }
            catch (Exception) {
                MsgBoxUtil.ErrMsgBox("商品信息输入错误！");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            Close();
        }

        private void FrmCategoryInsert_FormClosing(object sender, FormClosingEventArgs e) {
            Close();
        }
    }
}
