namespace GoodManagerSys.Frm.ReportForm
{
    partial class FrmPurchaseReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TabPurchaseReport = new System.Windows.Forms.TabControl();
            this.TabPurchaseTable = new System.Windows.Forms.TabPage();
            this.DgvPurchaseDetail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabCategoryTable = new System.Windows.Forms.TabPage();
            this.DgvCategoryDetail = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabChart = new System.Windows.Forms.TabPage();
            this.RdoBarGraph = new System.Windows.Forms.RadioButton();
            this.RdoPieGraph = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpBegin = new System.Windows.Forms.DateTimePicker();
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.ChartBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartPieCosts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartPieCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TabPurchaseReport.SuspendLayout();
            this.TabPurchaseTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPurchaseDetail)).BeginInit();
            this.TabCategoryTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategoryDetail)).BeginInit();
            this.TabChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPieCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPieCount)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPurchaseReport
            // 
            this.TabPurchaseReport.Controls.Add(this.TabPurchaseTable);
            this.TabPurchaseReport.Controls.Add(this.TabCategoryTable);
            this.TabPurchaseReport.Controls.Add(this.TabChart);
            this.TabPurchaseReport.Location = new System.Drawing.Point(12, 90);
            this.TabPurchaseReport.Name = "TabPurchaseReport";
            this.TabPurchaseReport.SelectedIndex = 0;
            this.TabPurchaseReport.Size = new System.Drawing.Size(1177, 658);
            this.TabPurchaseReport.TabIndex = 0;
            // 
            // TabPurchaseTable
            // 
            this.TabPurchaseTable.Controls.Add(this.DgvPurchaseDetail);
            this.TabPurchaseTable.Location = new System.Drawing.Point(8, 39);
            this.TabPurchaseTable.Name = "TabPurchaseTable";
            this.TabPurchaseTable.Padding = new System.Windows.Forms.Padding(3);
            this.TabPurchaseTable.Size = new System.Drawing.Size(1161, 611);
            this.TabPurchaseTable.TabIndex = 0;
            this.TabPurchaseTable.Text = "采购商品明细";
            this.TabPurchaseTable.UseVisualStyleBackColor = true;
            // 
            // DgvPurchaseDetail
            // 
            this.DgvPurchaseDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPurchaseDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.DgvPurchaseDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPurchaseDetail.Location = new System.Drawing.Point(3, 3);
            this.DgvPurchaseDetail.Name = "DgvPurchaseDetail";
            this.DgvPurchaseDetail.RowTemplate.Height = 37;
            this.DgvPurchaseDetail.Size = new System.Drawing.Size(1155, 605);
            this.DgvPurchaseDetail.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "单号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "日期";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "商品名称";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "单位";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "单价";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 50F;
            this.Column6.HeaderText = "数量";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "总金额";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.FillWeight = 70F;
            this.Column8.HeaderText = "颜色";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "经办人";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // TabCategoryTable
            // 
            this.TabCategoryTable.Controls.Add(this.DgvCategoryDetail);
            this.TabCategoryTable.Location = new System.Drawing.Point(8, 39);
            this.TabCategoryTable.Name = "TabCategoryTable";
            this.TabCategoryTable.Padding = new System.Windows.Forms.Padding(3);
            this.TabCategoryTable.Size = new System.Drawing.Size(1161, 611);
            this.TabCategoryTable.TabIndex = 1;
            this.TabCategoryTable.Text = "采购商品分类统计表";
            this.TabCategoryTable.UseVisualStyleBackColor = true;
            // 
            // DgvCategoryDetail
            // 
            this.DgvCategoryDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategoryDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12});
            this.DgvCategoryDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCategoryDetail.Location = new System.Drawing.Point(3, 3);
            this.DgvCategoryDetail.Name = "DgvCategoryDetail";
            this.DgvCategoryDetail.RowTemplate.Height = 37;
            this.DgvCategoryDetail.Size = new System.Drawing.Size(1155, 605);
            this.DgvCategoryDetail.TabIndex = 0;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "类别名称";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "采购数量";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.HeaderText = "采购金额";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // TabChart
            // 
            this.TabChart.Controls.Add(this.RdoPieGraph);
            this.TabChart.Controls.Add(this.RdoBarGraph);
            this.TabChart.Controls.Add(this.ChartPieCount);
            this.TabChart.Controls.Add(this.ChartPieCosts);
            this.TabChart.Controls.Add(this.ChartBar);
            this.TabChart.Location = new System.Drawing.Point(8, 39);
            this.TabChart.Name = "TabChart";
            this.TabChart.Padding = new System.Windows.Forms.Padding(3);
            this.TabChart.Size = new System.Drawing.Size(1161, 611);
            this.TabChart.TabIndex = 2;
            this.TabChart.Text = "采购商品分类统计图表";
            this.TabChart.UseVisualStyleBackColor = true;
            // 
            // RdoBarGraph
            // 
            this.RdoBarGraph.AutoSize = true;
            this.RdoBarGraph.Checked = true;
            this.RdoBarGraph.Location = new System.Drawing.Point(881, 23);
            this.RdoBarGraph.Name = "RdoBarGraph";
            this.RdoBarGraph.Size = new System.Drawing.Size(113, 28);
            this.RdoBarGraph.TabIndex = 0;
            this.RdoBarGraph.TabStop = true;
            this.RdoBarGraph.Text = "柱状图";
            this.RdoBarGraph.UseVisualStyleBackColor = true;
            this.RdoBarGraph.CheckedChanged += new System.EventHandler(this.RdoBarGraph_CheckedChanged);
            // 
            // RdoPieGraph
            // 
            this.RdoPieGraph.AutoSize = true;
            this.RdoPieGraph.Location = new System.Drawing.Point(1028, 23);
            this.RdoPieGraph.Name = "RdoPieGraph";
            this.RdoPieGraph.Size = new System.Drawing.Size(113, 28);
            this.RdoPieGraph.TabIndex = 1;
            this.RdoPieGraph.Text = "饼状图";
            this.RdoPieGraph.UseVisualStyleBackColor = true;
            this.RdoPieGraph.CheckedChanged += new System.EventHandler(this.RdoPieGraph_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "采购日期：";
            // 
            // DtpBegin
            // 
            this.DtpBegin.Location = new System.Drawing.Point(131, 22);
            this.DtpBegin.Name = "DtpBegin";
            this.DtpBegin.Size = new System.Drawing.Size(200, 35);
            this.DtpBegin.TabIndex = 2;
            // 
            // DtpEnd
            // 
            this.DtpEnd.Location = new System.Drawing.Point(432, 22);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(200, 35);
            this.DtpEnd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "至";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(867, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "商品类别：";
            // 
            // CmbCategory
            // 
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Items.AddRange(new object[] {
            "不限",
            "未分类",
            "饮料",
            "酒",
            "香烟",
            "糕饼",
            "糖果",
            "奶制品",
            "休闲食品"});
            this.CmbCategory.Location = new System.Drawing.Point(1027, 21);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(151, 32);
            this.CmbCategory.TabIndex = 6;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(861, 754);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(153, 46);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.Text = "查询";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(1036, 754);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(142, 46);
            this.BtnQuit.TabIndex = 10;
            this.BtnQuit.Text = "退出";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // ChartBar
            // 
            chartArea9.Name = "ChartArea1";
            this.ChartBar.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.ChartBar.Legends.Add(legend9);
            this.ChartBar.Location = new System.Drawing.Point(37, 74);
            this.ChartBar.Name = "ChartBar";
            series11.ChartArea = "ChartArea1";
            series11.IsValueShownAsLabel = true;
            series11.Legend = "Legend1";
            series11.Name = "采购数量";
            series12.ChartArea = "ChartArea1";
            series12.IsValueShownAsLabel = true;
            series12.Legend = "Legend1";
            series12.Name = "采购成本";
            this.ChartBar.Series.Add(series11);
            this.ChartBar.Series.Add(series12);
            this.ChartBar.Size = new System.Drawing.Size(1104, 505);
            this.ChartBar.TabIndex = 4;
            this.ChartBar.Text = "chart1";
            title9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title9.Name = "Title";
            title9.Text = "分类采购统计图";
            this.ChartBar.Titles.Add(title9);
            this.ChartBar.Visible = false;
            // 
            // ChartPieCosts
            // 
            chartArea8.Name = "ChartArea1";
            this.ChartPieCosts.ChartAreas.Add(chartArea8);
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.ChartPieCosts.Legends.Add(legend8);
            this.ChartPieCosts.Location = new System.Drawing.Point(595, 69);
            this.ChartPieCosts.Name = "ChartPieCosts";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.IsValueShownAsLabel = true;
            series10.Label = "#VALX ：#VAL";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.ChartPieCosts.Series.Add(series10);
            this.ChartPieCosts.Size = new System.Drawing.Size(546, 505);
            this.ChartPieCosts.TabIndex = 7;
            this.ChartPieCosts.Text = "chart2";
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.Name = "Title1";
            title8.Text = "分类采购成本统计图";
            this.ChartPieCosts.Titles.Add(title8);
            this.ChartPieCosts.Visible = false;
            // 
            // ChartPieCount
            // 
            chartArea7.Name = "ChartArea1";
            this.ChartPieCount.ChartAreas.Add(chartArea7);
            legend7.Enabled = false;
            legend7.Name = "Legend1";
            this.ChartPieCount.Legends.Add(legend7);
            this.ChartPieCount.Location = new System.Drawing.Point(49, 73);
            this.ChartPieCount.Name = "ChartPieCount";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.IsValueShownAsLabel = true;
            series9.Label = "#VALX ：#VAL";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.ChartPieCount.Series.Add(series9);
            this.ChartPieCount.Size = new System.Drawing.Size(546, 505);
            this.ChartPieCount.TabIndex = 8;
            this.ChartPieCount.Text = "chart1";
            this.ChartPieCount.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.Name = "Title1";
            title7.Text = "分类采购数量统计图";
            this.ChartPieCount.Titles.Add(title7);
            this.ChartPieCount.Visible = false;
            // 
            // FrmPurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 812);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.CmbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpEnd);
            this.Controls.Add(this.DtpBegin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabPurchaseReport);
            this.Name = "FrmPurchaseReport";
            this.Text = "FrmPurchaseReport";
            this.TabPurchaseReport.ResumeLayout(false);
            this.TabPurchaseTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPurchaseDetail)).EndInit();
            this.TabCategoryTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategoryDetail)).EndInit();
            this.TabChart.ResumeLayout(false);
            this.TabChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPieCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPieCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabPurchaseReport;
        private System.Windows.Forms.TabPage TabPurchaseTable;
        private System.Windows.Forms.TabPage TabCategoryTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpBegin;
        private System.Windows.Forms.DateTimePicker DtpEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.DataGridView DgvPurchaseDetail;
        private System.Windows.Forms.TabPage TabChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView DgvCategoryDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.RadioButton RdoBarGraph;
        private System.Windows.Forms.RadioButton RdoPieGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPieCosts;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPieCount;
    }
}