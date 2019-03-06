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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.RdoPieGraph = new System.Windows.Forms.RadioButton();
            this.RdoBarGraph = new System.Windows.Forms.RadioButton();
            this.ChartPieCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartPieCosts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpBegin = new System.Windows.Forms.DateTimePicker();
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TabPurchaseReport.SuspendLayout();
            this.TabPurchaseTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPurchaseDetail)).BeginInit();
            this.TabCategoryTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategoryDetail)).BeginInit();
            this.TabChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPieCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPieCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPurchaseReport
            // 
            this.TabPurchaseReport.Controls.Add(this.TabPurchaseTable);
            this.TabPurchaseReport.Controls.Add(this.TabCategoryTable);
            this.TabPurchaseReport.Controls.Add(this.TabChart);
            this.TabPurchaseReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPurchaseReport.Location = new System.Drawing.Point(2, 33);
            this.TabPurchaseReport.Margin = new System.Windows.Forms.Padding(2);
            this.TabPurchaseReport.Name = "TabPurchaseReport";
            this.TabPurchaseReport.SelectedIndex = 0;
            this.TabPurchaseReport.Size = new System.Drawing.Size(712, 339);
            this.TabPurchaseReport.TabIndex = 0;
            // 
            // TabPurchaseTable
            // 
            this.TabPurchaseTable.Controls.Add(this.DgvPurchaseDetail);
            this.TabPurchaseTable.Location = new System.Drawing.Point(4, 22);
            this.TabPurchaseTable.Margin = new System.Windows.Forms.Padding(2);
            this.TabPurchaseTable.Name = "TabPurchaseTable";
            this.TabPurchaseTable.Padding = new System.Windows.Forms.Padding(2);
            this.TabPurchaseTable.Size = new System.Drawing.Size(704, 313);
            this.TabPurchaseTable.TabIndex = 0;
            this.TabPurchaseTable.Text = "采购商品明细";
            this.TabPurchaseTable.UseVisualStyleBackColor = true;
            // 
            // DgvPurchaseDetail
            // 
            this.DgvPurchaseDetail.AllowUserToAddRows = false;
            this.DgvPurchaseDetail.AllowUserToDeleteRows = false;
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
            this.DgvPurchaseDetail.Location = new System.Drawing.Point(2, 2);
            this.DgvPurchaseDetail.Margin = new System.Windows.Forms.Padding(2);
            this.DgvPurchaseDetail.Name = "DgvPurchaseDetail";
            this.DgvPurchaseDetail.RowTemplate.Height = 37;
            this.DgvPurchaseDetail.Size = new System.Drawing.Size(700, 309);
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
            this.TabCategoryTable.Location = new System.Drawing.Point(4, 22);
            this.TabCategoryTable.Margin = new System.Windows.Forms.Padding(2);
            this.TabCategoryTable.Name = "TabCategoryTable";
            this.TabCategoryTable.Padding = new System.Windows.Forms.Padding(2);
            this.TabCategoryTable.Size = new System.Drawing.Size(704, 313);
            this.TabCategoryTable.TabIndex = 1;
            this.TabCategoryTable.Text = "采购商品分类统计表";
            this.TabCategoryTable.UseVisualStyleBackColor = true;
            // 
            // DgvCategoryDetail
            // 
            this.DgvCategoryDetail.AllowUserToAddRows = false;
            this.DgvCategoryDetail.AllowUserToDeleteRows = false;
            this.DgvCategoryDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategoryDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12});
            this.DgvCategoryDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCategoryDetail.Location = new System.Drawing.Point(2, 2);
            this.DgvCategoryDetail.Margin = new System.Windows.Forms.Padding(2);
            this.DgvCategoryDetail.Name = "DgvCategoryDetail";
            this.DgvCategoryDetail.RowTemplate.Height = 37;
            this.DgvCategoryDetail.Size = new System.Drawing.Size(700, 309);
            this.DgvCategoryDetail.TabIndex = 0;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "类别名称";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "采购数量";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.HeaderText = "采购金额";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TabChart
            // 
            this.TabChart.Controls.Add(this.RdoPieGraph);
            this.TabChart.Controls.Add(this.RdoBarGraph);
            this.TabChart.Controls.Add(this.ChartPieCount);
            this.TabChart.Controls.Add(this.ChartPieCosts);
            this.TabChart.Controls.Add(this.ChartBar);
            this.TabChart.Location = new System.Drawing.Point(4, 22);
            this.TabChart.Margin = new System.Windows.Forms.Padding(2);
            this.TabChart.Name = "TabChart";
            this.TabChart.Padding = new System.Windows.Forms.Padding(2);
            this.TabChart.Size = new System.Drawing.Size(704, 313);
            this.TabChart.TabIndex = 2;
            this.TabChart.Text = "采购商品分类统计图表";
            this.TabChart.UseVisualStyleBackColor = true;
            // 
            // RdoPieGraph
            // 
            this.RdoPieGraph.AutoSize = true;
            this.RdoPieGraph.Location = new System.Drawing.Point(514, 12);
            this.RdoPieGraph.Margin = new System.Windows.Forms.Padding(2);
            this.RdoPieGraph.Name = "RdoPieGraph";
            this.RdoPieGraph.Size = new System.Drawing.Size(59, 16);
            this.RdoPieGraph.TabIndex = 1;
            this.RdoPieGraph.Text = "饼状图";
            this.RdoPieGraph.UseVisualStyleBackColor = true;
            this.RdoPieGraph.CheckedChanged += new System.EventHandler(this.RdoPieGraph_CheckedChanged);
            // 
            // RdoBarGraph
            // 
            this.RdoBarGraph.AutoSize = true;
            this.RdoBarGraph.Checked = true;
            this.RdoBarGraph.Location = new System.Drawing.Point(440, 12);
            this.RdoBarGraph.Margin = new System.Windows.Forms.Padding(2);
            this.RdoBarGraph.Name = "RdoBarGraph";
            this.RdoBarGraph.Size = new System.Drawing.Size(59, 16);
            this.RdoBarGraph.TabIndex = 0;
            this.RdoBarGraph.TabStop = true;
            this.RdoBarGraph.Text = "柱状图";
            this.RdoBarGraph.UseVisualStyleBackColor = true;
            this.RdoBarGraph.CheckedChanged += new System.EventHandler(this.RdoBarGraph_CheckedChanged);
            // 
            // ChartPieCount
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartPieCount.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.ChartPieCount.Legends.Add(legend1);
            this.ChartPieCount.Location = new System.Drawing.Point(24, 36);
            this.ChartPieCount.Margin = new System.Windows.Forms.Padding(2);
            this.ChartPieCount.Name = "ChartPieCount";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Label = "#VALX ：#VAL";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartPieCount.Series.Add(series1);
            this.ChartPieCount.Size = new System.Drawing.Size(273, 252);
            this.ChartPieCount.TabIndex = 8;
            this.ChartPieCount.Text = "chart1";
            this.ChartPieCount.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "分类采购数量统计图";
            this.ChartPieCount.Titles.Add(title1);
            this.ChartPieCount.Visible = false;
            // 
            // ChartPieCosts
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartPieCosts.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.ChartPieCosts.Legends.Add(legend2);
            this.ChartPieCosts.Location = new System.Drawing.Point(298, 34);
            this.ChartPieCosts.Margin = new System.Windows.Forms.Padding(2);
            this.ChartPieCosts.Name = "ChartPieCosts";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Label = "#VALX ：#VAL";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartPieCosts.Series.Add(series2);
            this.ChartPieCosts.Size = new System.Drawing.Size(273, 252);
            this.ChartPieCosts.TabIndex = 7;
            this.ChartPieCosts.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "分类采购成本统计图";
            this.ChartPieCosts.Titles.Add(title2);
            this.ChartPieCosts.Visible = false;
            // 
            // ChartBar
            // 
            chartArea3.Name = "ChartArea1";
            this.ChartBar.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartBar.Legends.Add(legend3);
            this.ChartBar.Location = new System.Drawing.Point(18, 37);
            this.ChartBar.Margin = new System.Windows.Forms.Padding(2);
            this.ChartBar.Name = "ChartBar";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "采购数量";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "采购成本";
            this.ChartBar.Series.Add(series3);
            this.ChartBar.Series.Add(series4);
            this.ChartBar.Size = new System.Drawing.Size(552, 252);
            this.ChartBar.TabIndex = 4;
            this.ChartBar.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title";
            title3.Text = "分类采购统计图";
            this.ChartBar.Titles.Add(title3);
            this.ChartBar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "采购日期：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DtpBegin
            // 
            this.DtpBegin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DtpBegin.Location = new System.Drawing.Point(134, 2);
            this.DtpBegin.Margin = new System.Windows.Forms.Padding(2);
            this.DtpBegin.Name = "DtpBegin";
            this.DtpBegin.Size = new System.Drawing.Size(128, 21);
            this.DtpBegin.TabIndex = 2;
            // 
            // DtpEnd
            // 
            this.DtpEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DtpEnd.Location = new System.Drawing.Point(313, 2);
            this.DtpEnd.Margin = new System.Windows.Forms.Padding(2);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(128, 21);
            this.DtpEnd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(266, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "至";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(445, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "商品类别：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbCategory
            // 
            this.CmbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.CmbCategory.Location = new System.Drawing.Point(577, 2);
            this.CmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(131, 20);
            this.CmbCategory.TabIndex = 6;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSearch.Location = new System.Drawing.Point(570, 2);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(67, 23);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.Text = "查询";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnQuit.Location = new System.Drawing.Point(641, 2);
            this.BtnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(67, 23);
            this.BtnQuit.TabIndex = 10;
            this.BtnQuit.Text = "退出";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TabPurchaseReport, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 407);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.65672F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.65672F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.716418F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.65672F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.65672F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.65672F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DtpBegin, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.CmbCategory, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.DtpEnd, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(710, 25);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.BtnQuit, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnSearch, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 377);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(710, 27);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // FrmPurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPurchaseReport";
            this.Text = "FrmPurchaseReport";
            this.TabPurchaseReport.ResumeLayout(false);
            this.TabPurchaseTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPurchaseDetail)).EndInit();
            this.TabCategoryTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategoryDetail)).EndInit();
            this.TabChart.ResumeLayout(false);
            this.TabChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPieCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPieCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.RadioButton RdoBarGraph;
        private System.Windows.Forms.RadioButton RdoPieGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPieCosts;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPieCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}