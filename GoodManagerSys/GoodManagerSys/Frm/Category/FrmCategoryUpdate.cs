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

namespace GoodManagerSys.Frm.Category
{
    public partial class FrmCategoryUpdate : Form
    {
        public FrmCategoryUpdate()
        {
            InitializeComponent();
            TxtCategoryName.Text = FrmCategory.category.CategoryName;
            CmbParentCategoryName.SelectedIndex = (int)FrmCategory.category.ParentCategoryID;
            TxtFirm.Text = FrmCategory.category.Firm;
            TxtUnit.Text = FrmCategory.category.Unit;
            TxtColor.Text = FrmCategory.category.Color;
            TxtExpirationDate.Text = FrmCategory.category.ExpirationDate.ToString();
            TxtMinStock.Text = FrmCategory.category.MinStock.ToString();
            TxtMaxStock.Text = FrmCategory.category.MaxStock.ToString();
        }

        private void BtnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                string CategoryName = TxtCategoryName.Text;
                ECategory ParentCategoryEnum = (ECategory)CmbParentCategoryName.SelectedIndex;
                string ParentCategoryName = ParentCategoryEnum.ToString();
                string Firm = TxtFirm.Text;
                string Unit = TxtUnit.Text;
                string Color = TxtColor.Text;
                int ExpirationDate = int.Parse(TxtExpirationDate.Text);
                int MinStock = int.Parse(TxtMinStock.Text);
                int MaxStock = int.Parse(TxtMaxStock.Text);
                EtCategory category = new EtCategory
                {
                    CategoryID= FrmCategory.category.CategoryID,
                    CategoryName = CategoryName,
                    ParentCategoryID = ParentCategoryEnum,
                    ParentCategoryName = ParentCategoryName,
                    Unit = Unit,
                    Color = Color,
                    Firm = Firm,
                    MinStock = MinStock,
                    MaxStock = MaxStock,
                    ExpirationDate = ExpirationDate,
                    IsValid = FrmCategory.category.IsValid
                };
                CategoryDao.UpdateCategory(category);
                FrmCategory.category = category;
                Console.WriteLine(category.ToString());
                Close();
            }
            catch (Exception)
            {
                MsgBoxUtil.ErrMsgBox("商品信息输入错误！");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
