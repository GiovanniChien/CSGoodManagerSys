using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Utils;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Sale {
    public partial class FrmSaleQuery : Form {
        private List<EtSale> sales;
        private List<EtGood> goods;
        public FrmSaleQuery() {
            InitializeComponent();
            sales = SaleDao.QueryAll();
            DgvSalAdd(sales);
            DgvGoodAdd(sales);
            RdoSale.Checked = true;
        }

        private void BtnQuery_Click(object sender, EventArgs e) {
            if (TxtQuery.Text != "") {
                List<EtSale> subSales = new List<EtSale>();
                List<EtGood> subGoods = new List<EtGood>();
                string query = TxtQuery.Text;
                string RegexStr = "^[0-9]+$";
                if (RdoSale.Checked) {
                    if (Regex.IsMatch(query, RegexStr)) {
                        subSales = SaleDao.QueryBySaleID(int.Parse(query));
                        if (subSales.Count == 0)
                            subSales = SaleDao.QueryByStaffID(int.Parse(query));
                    }
                    if (subSales.Count == 0)
                        MsgBoxUtil.ErrMsgBox("未找到销售单！");
                    else
                        subGoods = GoodDao.QueryByGoodID(subSales[0].Good.GoodID);
                }
                else {
                    if (Regex.IsMatch(query, RegexStr))
                        subGoods = GoodDao.QueryByGoodID(int.Parse(query));
                    else
                        subGoods = GoodDao.QueryByCategoryID(CategoryDao.QueryByCategoryName(query)[0].CategoryID);
                    if (subGoods.Count == 0)
                        MsgBoxUtil.ErrMsgBox("未找到商品！");
                    else {
                        for (int i = 0; i < subGoods.Count; i++)
                            if (subGoods[i].State == Enums.EState.已出售)
                                subSales.Add(SaleDao.QueryByGoodID(subGoods[i].GoodID)[0]);
                            else {
                                subGoods.RemoveAt(i);
                                i--;
                            }
                    }
                }
                DgvAdd(subSales, subGoods);
            }
            else
                MsgBoxUtil.ErrMsgBox("请输入查询条件！");
        }

        private void DgvSaleResult_CellClick(object sender, DataGridViewCellEventArgs e) {
            sales = SaleDao.QueryBySaleID(int.Parse(DgvSaleResult.SelectedRows[0].Cells[0].Value.ToString()));
            DgvGoodAdd(sales);
        }

        private void DgvGoodInfo_CellClick(object sender, DataGridViewCellEventArgs e) {
            sales = SaleDao.QueryByGoodID(int.Parse(DgvGoodInfo.SelectedRows[0].Cells[0].Value.ToString()));
            DgvSalAdd(sales);
        }

        private void DgvSalAdd(List<EtSale> sales) {
            DgvSaleResult.Rows.Clear();
            int saleID = 0;
            for (int i = 0; i < sales.Count; i++)
                if (saleID != sales[i].SaleID) {
                    DgvSaleResult.Rows.Add(new object[] {
                        sales[i].SaleID,
                        sales[i].SaleDate,
                        StaffDao.QueryByStaffID(sales[i].StaffID)[0].StaffName
                    });
                    saleID = sales[i].SaleID;
                }
        }

        private void DgvGoodAdd(List<EtSale> sales) {
            DgvGoodInfo.Rows.Clear();
            sales = SaleDao.QueryBySaleID(sales[0].SaleID);
            for (int i = 0; i < sales.Count; i++) {
                goods = GoodDao.QueryByGoodID(sales[i].Good.GoodID);
                DgvGoodInfo.Rows.Add(new object[] {
                    goods[0].GoodID,
                    goods[0].Category.CategoryName,
                    goods[0].Category.Unit,
                    goods[0].Price
                });
            }
        }

        private void DgvAdd(List<EtSale> subSales, List<EtGood> subGoods) {
            DgvSalAdd(subSales);
            DgvGoodInfo.Rows.Clear();
            for (int i = 0; i < subGoods.Count; i++) {
                DgvGoodInfo.Rows.Add(new object[] {
                    subGoods[i].GoodID,
                    subGoods[i].Category.CategoryName,
                    subGoods[i].Category.Unit,
                    subGoods[i].Price
                });
            }
        }
    }
}
