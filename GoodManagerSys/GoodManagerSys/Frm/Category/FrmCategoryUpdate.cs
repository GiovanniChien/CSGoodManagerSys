using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using System;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Category {
    public partial class FrmCategoryUpdate : Form {
        public FrmCategoryUpdate() {
            InitializeComponent();
            TxtCategoryName.Text = FrmCategory.category.CategoryName;
            CmbParentCategoryName.SelectedIndex = (int)FrmCategory.category.ParentCategoryID;
            TxtFirm.Text = FrmCategory.category.Firm;
            TxtUnit.Text = FrmCategory.category.Unit;
            TxtColor.Text = FrmCategory.category.Color;
            TxtExpirationDate.Text = FrmCategory.category.ExpirationDate.ToString();
            TxtMinStock.Text = FrmCategory.category.MinStock.ToString();
            TxtMaxStock.Text = FrmCategory.category.MaxStock.ToString();
            CmbIsValid.SelectedIndex = (int)FrmCategory.category.IsValid;
        }

        private void BtnCommit_Click(object sender, EventArgs e) {
            try {
                if (TxtCategoryName.Text == "")
                    MsgBoxUtil.ErrMsgBox("商品名称不得为空！");
                else
                {
                    FrmCategory.category = new EtCategory
                    {
                        CategoryID = FrmCategory.category.CategoryID,
                        CategoryName = TxtCategoryName.Text,
                        ParentCategoryID = (ECategory)CmbParentCategoryName.SelectedIndex,
                        ParentCategoryName = ((ECategory)CmbParentCategoryName.SelectedIndex).ToString(),
                        Unit = TxtUnit.Text,
                        Color = TxtColor.Text,
                        Firm = TxtFirm.Text,
                        MinStock = int.Parse(TxtMinStock.Text),
                        MaxStock = int.Parse(TxtMaxStock.Text),
                        ExpirationDate = int.Parse(TxtExpirationDate.Text),
                        IsValid = (EValid)CmbIsValid.SelectedIndex
                    };
                    Close();
                }
            }
            catch (Exception) {
                MsgBoxUtil.ErrMsgBox("商品信息输入错误！");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            if ("" == TxtCategoryName.Text && -1 == CmbParentCategoryName.SelectedIndex && "" == TxtFirm.Text &&
                "" == TxtUnit.Text && "" == TxtColor.Text && "" == TxtExpirationDate.Text &&
                "" == TxtMinStock.Text && "" == TxtMaxStock.Text)
                Close();
            else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
                Close();
        }

        //private void FrmCategoryUpdate_FormClosing(object sender, FormClosingEventArgs e) {
        //    if ("" == TxtCategoryName.Text && -1 == CmbParentCategoryName.SelectedIndex && "" == TxtFirm.Text &&
        //        "" == TxtUnit.Text && "" == TxtColor.Text && "" == TxtExpirationDate.Text &&
        //        "" == TxtMinStock.Text && "" == TxtMaxStock.Text)
        //        Close();
        //    else if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体有未提交的数据，是否确定退出？"))
        //        Close();
        //}
    }
}
