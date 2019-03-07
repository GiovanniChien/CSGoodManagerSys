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
            if (hasUpdated) {
                if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
                    Close();
            }
            else
                Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            FrmCategoryInsert fci = new FrmCategoryInsert {
                StartPosition = FormStartPosition.CenterParent
            };
            fci.ShowDialog();
            if (category != null)
            {
                categories.Add(category);
                category = null;
                if (categories.Count > 1)
                    categories[categories.Count - 1].CategoryID = categories[categories.Count - 2].CategoryID + 1;
                DgvCategory.Rows.Add(new object[] {
                    categories[categories.Count - 1].CategoryID,
                    categories[categories.Count - 1].CategoryName,
                    categories[categories.Count - 1].ParentCategoryName,
                    categories[categories.Count - 1].Firm,
                    categories[categories.Count - 1].Unit,
                    categories[categories.Count - 1].Color,
                    categories[categories.Count - 1].ExpirationDate,
                    categories[categories.Count - 1].MinStock,
                    categories[categories.Count - 1].MaxStock,
                    categories[categories.Count - 1].IsValid
                });
                hasUpdated = true;
            }
            hasUpdated = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e) {
            if (DgvCategory.SelectedRows.Count == 1) {
                int index = DgvCategory.SelectedRows[0].Index;
                category = categories[index];
                FrmCategoryUpdate fmu = new FrmCategoryUpdate {
                    StartPosition = FormStartPosition.CenterParent
                };
                fmu.ShowDialog();
                if (category != null)
                {
                    DgvCategory.Rows[index].Cells["Column1"].Value = category.CategoryID;
                    DgvCategory.Rows[index].Cells["Column2"].Value = category.CategoryName;
                    DgvCategory.Rows[index].Cells["Column3"].Value = category.ParentCategoryName;
                    DgvCategory.Rows[index].Cells["Column7"].Value = category.Firm;
                    DgvCategory.Rows[index].Cells["Column5"].Value = category.Unit;
                    DgvCategory.Rows[index].Cells["Column6"].Value = category.Color;
                    DgvCategory.Rows[index].Cells["Column10"].Value = category.ExpirationDate;
                    DgvCategory.Rows[index].Cells["Column8"].Value = category.MinStock;
                    DgvCategory.Rows[index].Cells["Column9"].Value = category.MaxStock;
                    DgvCategory.Rows[index].Cells["Column11"].Value = category.IsValid;
                    categories[index] = category;
                    category = null;
                }
                hasUpdated = true;
            }
            else
                MsgBoxUtil.ErrMsgBox("请选择要修改的商品信息！");
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            if (DgvCategory.SelectedRows.Count == 1) {
                int index = DgvCategory.SelectedRows[0].Index;
                category = categories[index];
                if (EValid.有效 == category.IsValid) 
                    if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("是否删除当前商品？")) {
                        CategoryDao.DeleteByCategoryID(category.CategoryID);
                        categories[index].IsValid = EValid.已删除;
                        DgvCategory.Rows[index].Cells["Column11"].Value = EValid.已删除;
                        category = null;
                    }
            }
            else
                MsgBoxUtil.ErrMsgBox("请选择要删除的商品！");
        }

        private void BtnSubmit_Click(object sender, EventArgs e) {
            DialogResult result = MsgBoxUtil.QuestionMsgBox("确定提交修改?");
            if (hasUpdated&&result==DialogResult.OK) {
                foreach (EtCategory category in categories)
                    CategoryDao.UpdateOrInsert(category);
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

        //private void FrmCategory_FormClosing(object sender, FormClosingEventArgs e) {
        //    if (hasUpdated) {
        //        if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
        //            e.Cancel = false;
        //    }
        //    else
        //        e.Cancel = false;
        //}
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
