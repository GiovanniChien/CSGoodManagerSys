﻿using GoodManagerSys.Dao;
using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Frm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GoodManagerSys.Utils;

namespace GoodManagerSys
{
    public partial class FrmGoodInsert : Form
    {
        public FrmGoodInsert()
        {
            InitializeComponent();
            CmbIsValid.SelectedIndex = 0;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            ClsGood good = GetGoodFromInput();
            if (good != null)
            {
                DialogResult res = MsgBoxUtil.QuestionMsgBox("确认提交？");
                if (res == DialogResult.OK)
                {
                    FrmGoodIncome.Goods.Add(good);
                    this.Close();
                }
            }
        }

        private ClsGood GetGoodFromInput()
        {
            ClsGood good = null;
            try
            {
                int categoryID = int.Parse(TxtCategoryID.Text);
                string productionDate = DtpProductionID.Value.ToString("yyyyMMdd");
                double cost = double.Parse(TxtCost.Text);
                double price = TxtPrice.Text != "" ? double.Parse(TxtPrice.Text) : 0;
                int count = TxtCount.Text != "" ? int.Parse(TxtCount.Text) : 0;
                EState state = (EState)CmbIsValid.SelectedIndex;
                List<EtCategory> categories = CategoryDao.QueryByCategoryID(categoryID);
                if (count == 0)
                {
                    MsgBoxUtil.ErrMsgBox("商品数量不能为0！");
                }
                else
                {
                    if (categories.Count == 0)
                    {
                        MsgBoxUtil.ErrMsgBox("不存在该商品！");
                    }
                    else
                    {
                        good = new ClsGood
                        {
                            Good = new EtGood
                            {
                                Category = categories[0],
                                ProductionDate = productionDate,
                                Cost = cost,
                                Price = price,
                                State = state
                            },
                            Count = count
                        };
                    }
                }
            }
            catch (Exception)
            {
                MsgBoxUtil.ErrMsgBox("非法输入！");
            }
            return good;
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}