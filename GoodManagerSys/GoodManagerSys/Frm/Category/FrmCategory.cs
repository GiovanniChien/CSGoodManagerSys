using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Frm.Category;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GoodManagerSys {
    public partial class FrmCategory : Form {
        internal static EtCategory category;
        private List<EtCategory> categories;
        private bool hasUpdated;
        public FrmCategory() {
            InitializeComponent();
            CmbCategory.SelectedIndex = 0;
            category = new EtCategory();
            categories = CategoryDao.QueryAll();
            hasUpdated = false;
            DgvShow();
        }

        private void BtnQuery_Click(object sender, EventArgs e) {
            List<EtCategory> list1, list2;
            int index = CmbCategory.SelectedIndex;
            if (index == 0)
                list1 = CategoryDao.QueryAll();
            else
                list1 = CategoryDao.QueryByParentCategoryID((ECategory)index);
            string idOrName = TxtIdOrName.Text;
            string RegexStr = "^[0-9]+$";
            if (Regex.IsMatch(idOrName, RegexStr))
                list2 = CategoryDao.QueryByCategoryID(int.Parse(idOrName));
            else
                list2 = CategoryDao.QueryByCategoryName(idOrName);
            categories = list1.Intersect(list2, new MyCompare()).ToList();
            DgvShow();
        }

        private void DgvShow() {
            DgvCategory.Rows.Clear();
            DgvCategory.RowsDefaultCellStyle.BackColor = Color.White;
            DgvCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            DgvCategory.AllowUserToAddRows = false;
            for (int i = 0; i < categories.Count; i++) 
                DgvCategory.Rows.Add(new object[]{
                    categories[i].CategoryID,
                    categories[i].CategoryName,
                    categories[i].ParentCategoryName,
                    categories[i].Firm,
                    categories[i].Unit,
                    categories[i].Color,
                    categories[i].ExpirationDate,
                    categories[i].MinStock,
                    categories[i].MaxStock,
                    categories[i].IsValid
                });
        }

        private void BtnExit_Click(object sender, EventArgs e) {
            if(hasUpdated)
                MsgBoxUtil.ErrMsgBox("")
            Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            FrmCategoryInsert fci = new FrmCategoryInsert {
                StartPosition = FormStartPosition.CenterParent
            };
            fci.ShowDialog();
            hasUpdated = true;
            DgvShow();
        }

        private void BtnUpdate_Click(object sender, EventArgs e) {
            if (DgvCategory.SelectedRows.Count == 1) {
                int index = DgvCategory.SelectedRows[0].Index;
                category = categories[index];
                Console.WriteLine(category.ToString());
                FrmCategoryUpdate fmu = new FrmCategoryUpdate {
                    StartPosition = FormStartPosition.CenterParent
                };
                categories[index] = category;
                Console.WriteLine(category.ToString());
                fmu.ShowDialog();
                hasUpdated = true;
                DgvShow();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            if (DgvCategory.SelectedRows.Count == 1) {
                int index = DgvCategory.SelectedRows[0].Index;
                category = categories[index];
                if (EValid.有效 == category.IsValid) 
                    if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("是否删除当前商品？")) {
                        CategoryDao.DeleteByCategoryID(category.CategoryID);
                        category = null;
                    }
                hasUpdated = true;
                DgvShow();
            }
            else
                MsgBoxUtil.ErrMsgBox("请选择要删除的商品！");
        }

        private void BtnSubmit_Click(object sender, EventArgs e) {
            if (hasUpdated) {
                foreach (EtCategory category in categories)
                    CategoryDao.InsertCategory(category);
                hasUpdated = false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            if (hasUpdated) {
                categories = CategoryDao.QueryAll();
                DgvShow();
                hasUpdated = false;
            }
        }
    }

    class MyCompare : IEqualityComparer<EtCategory> {
        public bool Equals(EtCategory x, EtCategory y) {
            return x.CategoryID == y.CategoryID;
        }

        public int GetHashCode(EtCategory obj) {
            return obj.ToString().GetHashCode();
        }
    }
}
