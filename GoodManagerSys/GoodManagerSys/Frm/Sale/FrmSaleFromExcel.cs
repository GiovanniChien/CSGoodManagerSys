using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Utils;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Sale {
    public partial class FrmSaleFromExcel : Form {
        List<EtSale> excelSales;
        private string errInfo;
        private bool hasErr;
        private bool hasUpdated;
        public FrmSaleFromExcel() {
            InitializeComponent();
            excelSales = new List<EtSale>();
            errInfo = "";
            hasErr = false;
            hasUpdated = false;
        }

        private void BtnBrowse_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Title = "选择Excel文件",
                Filter = "excel文件(*.xls,*.xlsx)|*.xls;*.xlsx|excel03文件(*.xls)|*.xls|excel07文件(*.xlsx)|*.xlsx",
                RestoreDirectory = true
            };
            string excelPath = null;
            if (DialogResult.OK == openFileDialog.ShowDialog()) {
                excelPath = openFileDialog.FileName;
                TxtExcelPath.Text = excelPath;
            }
            using (FileStream fs = File.OpenRead(excelPath)) {
                IWorkbook workbook = null;
                //判断Excel的格式，区分xls与xlsx
                if (Path.GetExtension(fs.Name) == ".xls")
                    workbook = new HSSFWorkbook(fs);
                else if (Path.GetExtension(fs.Name) == ".xlsx")
                    workbook = new XSSFWorkbook(fs);
                //获取工作表
                ISheet sheet = workbook.GetSheetAt(0);
                //遍历行
                for (int i = 1; i <= sheet.LastRowNum; i++) {
                    IRow row = sheet.GetRow(i);
                    if (row != null) {
                        EtSale sale = ParseSale(row);
                        if (sale != null) {
                            excelSales.Add(sale);
                            DgvSaleFromExcel.Rows.Add(new object[] {
                                "√  "+i,
                                sale.Good.GoodID,
                                sale.Good.Category.CategoryName,
                                sale.Good.Category.Unit,
                                sale.Good.Price,
                                ""
                            });
                        }
                        else {
                            DgvSaleFromExcel.Rows.Add(new object[] { "×  " + i, "", "", "", "", errInfo });
                            DgvSaleFromExcel.Rows[i - 1].DefaultCellStyle.ForeColor = Color.Red;
                        }
                        hasUpdated = true;
                    }
                }
                DgvSaleFromExcel.RowsDefaultCellStyle.BackColor = Color.LightCyan;
                DgvSaleFromExcel.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            }
        }

        private EtSale ParseSale(IRow row) {
            if ("" == row.GetCell(0).ToString()) {
                errInfo = "商品不存在";
                hasErr = true;
                return null;
            }
            int goodID = int.Parse(row.GetCell(0).ToString());
            List<EtGood> goods = GoodDao.QueryByGoodID(goodID);
            if (0 == goods.Count || goods[0].State != Enums.EState.未出售) {
                errInfo = "商品不存在";
                hasErr = true;
                return null;
            }
            if ("" == row.GetCell(1).ToString()) {
                errInfo = "销售日期不能为空";
                hasErr = true;
                return null;
            }
            string saleDate = row.GetCell(1).ToString();
            if ("" == row.GetCell(2).ToString()) {
                errInfo = "售价不能为空";
                hasErr = true;
                return null;
            }
            int price = int.Parse(row.GetCell(2).ToString());
            EtSale sale = new EtSale {
                SaleID = 0,
                Good = goods[0],
                SaleDate = saleDate,
                Profit = price - goods[0].Cost
            };
            return sale;
        }

        private void BtnSubmit_Click(object sender, EventArgs e) {
            if (!hasErr) {
                foreach (EtSale sale in excelSales) {
                    FrmSale.Sales.Add(sale);
                }
                Close();
            }
            else {
                if (hasUpdated)
                    MsgBoxUtil.ErrMsgBox("导入失败！");
                else
                    MsgBoxUtil.ErrMsgBox("未导入数据！");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            if (hasUpdated) {
                if (DialogResult.OK == MsgBoxUtil.QuestionMsgBox("当前窗体留有修改信息，是否要退出？"))
                    Close();
            }
            else
                Close();
        }
    }
}
