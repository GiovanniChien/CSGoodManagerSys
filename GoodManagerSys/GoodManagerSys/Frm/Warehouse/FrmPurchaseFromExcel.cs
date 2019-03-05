using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GoodManagerSys.Frm.Warehouse {
    public partial class FrmPurchaseFromExcel : Form {
        List<ClsGood> excelGoods;
        private string errInfo;
        private bool hasErr;

        public FrmPurchaseFromExcel() {
            excelGoods = new List<ClsGood>();
            hasErr = false;
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Title = "选择Excel文件",
                Filter = "excel文件(*.xls,*.xlsx)|*.xls;*.xlsx|excel03文件(*.xls)|*.xls|excel07文件(*.xlsx)|*.xlsx",
                RestoreDirectory = true
            };
            string excelPath = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
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
                        ClsGood good = ParseGood(row);
                        if (good != null) {
                            excelGoods.Add(good);
                            DgvGoodFromExcel.Rows.Add(new object[]
                            {
                                "√  "+i,good.Good.Category.CategoryID,
                                good.Good.ProductionDate,
                                good.Good.Cost,
                                good.Good.Price,
                                good.Count,
                                good.Good.State,
                                ""
                            });
                        }
                        else {
                            DgvGoodFromExcel.Rows.Add(new object[] { "×  " + i, "", "", "", "", "", "", errInfo });
                            DgvGoodFromExcel.Rows[i - 1].DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
                DgvGoodFromExcel.RowsDefaultCellStyle.BackColor = Color.LightCyan;
                DgvGoodFromExcel.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            }
        }

        private ClsGood ParseGood(IRow row) {
            if (row.GetCell(0).ToString() == "") {
                errInfo = "商品不存在";
                hasErr = true;
                return null;
            }
            int categoryID = int.Parse(row.GetCell(0).ToString());
            List<EtCategory> categories = CategoryDao.QueryByCategoryID(categoryID);
            if (categories.Count == 0) {
                errInfo = "商品不存在";
                hasErr = true;
                return null;
            }
            string productionDate = row.GetCell(1).ToString();
            if (row.GetCell(2).ToString() == "") {
                errInfo = "进价不能为空";
                hasErr = true;
                return null;
            }
            double cost = double.Parse(row.GetCell(2).ToString());
            double price = row.GetCell(3).ToString() != "" ? double.Parse(row.GetCell(3).ToString()) : 0;
            int count = row.GetCell(4).ToString() != "" ? int.Parse(row.GetCell(4).ToString()) : 0;
            if (count == 0) {
                errInfo = "数量不能为空";
                hasErr = true;
                return null;
            }
            EState state = StringToEState(row.GetCell(5).ToString());
            ClsGood good = new ClsGood {
                Good = new EtGood {
                    Category = categories[0],
                    ProductionDate = productionDate,
                    Cost = cost,
                    Price = price,
                    State = state
                },
                Count = count
            };
            return good;
        }

        private void BtnSubmit_Click(object sender, EventArgs e) {
            DialogResult dr = MsgBoxUtil.QuestionMsgBox("确定提交？");
            if (dr == DialogResult.OK)
                if (!hasErr) {
                    FrmGoodIncome.Goods.AddRange(excelGoods);
                    Close();
                }
                else
                    MsgBoxUtil.ErrMsgBox("导入失败！");
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private EState StringToEState(string s) {
            if (s.Equals("未上架")) return EState.未上架;
            return EState.未出售;
        }
    }
}
