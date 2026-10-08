namespace StockFlow
{
    partial class DashboardControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            tlpSummary = new TableLayoutPanel();
            pnlProductCount = new Panel();
            pnlTotalStock = new Panel();
            pnlTodayMovements = new Panel();
            pnlLowStock = new Panel();
            lblProductCountTitle = new Label();
            lblTotalStockTitle = new Label();
            lblLowStockTitle = new Label();
            lblTodayMovementsTitle = new Label();
            lblProductCountValue = new Label();
            lblTotalStockValue = new Label();
            lblLowStockValue = new Label();
            lblTodayMovementsValue = new Label();
            lblSummaryTitle = new Label();
            tlpSummary.SuspendLayout();
            pnlProductCount.SuspendLayout();
            pnlTotalStock.SuspendLayout();
            pnlTodayMovements.SuspendLayout();
            pnlLowStock.SuspendLayout();
            SuspendLayout();
            // 
            // tlpSummary
            // 
            tlpSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpSummary.ColumnCount = 2;
            tlpSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSummary.Controls.Add(pnlProductCount, 0, 0);
            tlpSummary.Controls.Add(pnlTotalStock, 1, 0);
            tlpSummary.Controls.Add(pnlTodayMovements, 1, 1);
            tlpSummary.Controls.Add(pnlLowStock, 0, 1);
            tlpSummary.Location = new Point(25, 60);
            tlpSummary.Name = "tlpSummary";
            tlpSummary.RowCount = 2;
            tlpSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSummary.Size = new Size(840, 260);
            tlpSummary.TabIndex = 0;
            // 
            // pnlProductCount
            // 
            pnlProductCount.BackColor = Color.White;
            pnlProductCount.Controls.Add(lblProductCountValue);
            pnlProductCount.Controls.Add(lblProductCountTitle);
            pnlProductCount.Dock = DockStyle.Fill;
            pnlProductCount.Location = new Point(8, 8);
            pnlProductCount.Margin = new Padding(8);
            pnlProductCount.Name = "pnlProductCount";
            pnlProductCount.Size = new Size(404, 114);
            pnlProductCount.TabIndex = 0;
            // 
            // pnlTotalStock
            // 
            pnlTotalStock.BackColor = Color.White;
            pnlTotalStock.Controls.Add(lblTotalStockValue);
            pnlTotalStock.Controls.Add(lblTotalStockTitle);
            pnlTotalStock.Dock = DockStyle.Fill;
            pnlTotalStock.Location = new Point(428, 8);
            pnlTotalStock.Margin = new Padding(8);
            pnlTotalStock.Name = "pnlTotalStock";
            pnlTotalStock.Size = new Size(404, 114);
            pnlTotalStock.TabIndex = 1;
            // 
            // pnlTodayMovements
            // 
            pnlTodayMovements.BackColor = Color.White;
            pnlTodayMovements.Controls.Add(lblTodayMovementsValue);
            pnlTodayMovements.Controls.Add(lblTodayMovementsTitle);
            pnlTodayMovements.Dock = DockStyle.Fill;
            pnlTodayMovements.Location = new Point(428, 138);
            pnlTodayMovements.Margin = new Padding(8);
            pnlTodayMovements.Name = "pnlTodayMovements";
            pnlTodayMovements.Size = new Size(404, 114);
            pnlTodayMovements.TabIndex = 2;
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = Color.White;
            pnlLowStock.Controls.Add(lblLowStockValue);
            pnlLowStock.Controls.Add(lblLowStockTitle);
            pnlLowStock.Dock = DockStyle.Fill;
            pnlLowStock.Location = new Point(8, 138);
            pnlLowStock.Margin = new Padding(8);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(404, 114);
            pnlLowStock.TabIndex = 3;
            // 
            // lblProductCountTitle
            // 
            lblProductCountTitle.AutoSize = true;
            lblProductCountTitle.Font = new Font("Segoe UI", 10F);
            lblProductCountTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblProductCountTitle.Location = new Point(20, 18);
            lblProductCountTitle.Name = "lblProductCountTitle";
            lblProductCountTitle.Size = new Size(79, 19);
            lblProductCountTitle.TabIndex = 0;
            lblProductCountTitle.Text = "商品種類数";
            // 
            // lblTotalStockTitle
            // 
            lblTotalStockTitle.AutoSize = true;
            lblTotalStockTitle.Font = new Font("Segoe UI", 10F);
            lblTotalStockTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotalStockTitle.Location = new Point(20, 18);
            lblTotalStockTitle.Name = "lblTotalStockTitle";
            lblTotalStockTitle.Size = new Size(65, 19);
            lblTotalStockTitle.TabIndex = 0;
            lblTotalStockTitle.Text = "総在庫数";
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.AutoSize = true;
            lblLowStockTitle.Font = new Font("Segoe UI", 10F);
            lblLowStockTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblLowStockTitle.Location = new Point(20, 18);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(65, 19);
            lblLowStockTitle.TabIndex = 0;
            lblLowStockTitle.Text = "在庫不足";
            // 
            // lblTodayMovementsTitle
            // 
            lblTodayMovementsTitle.AutoSize = true;
            lblTodayMovementsTitle.Font = new Font("Segoe UI", 10F);
            lblTodayMovementsTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblTodayMovementsTitle.Location = new Point(20, 18);
            lblTodayMovementsTitle.Name = "lblTodayMovementsTitle";
            lblTodayMovementsTitle.Size = new Size(90, 19);
            lblTodayMovementsTitle.TabIndex = 0;
            lblTodayMovementsTitle.Text = "本日の入出庫";
            // 
            // lblProductCountValue
            // 
            lblProductCountValue.AutoSize = true;
            lblProductCountValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblProductCountValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblProductCountValue.Location = new Point(20, 48);
            lblProductCountValue.Name = "lblProductCountValue";
            lblProductCountValue.Size = new Size(38, 45);
            lblProductCountValue.TabIndex = 1;
            lblProductCountValue.Text = "0";
            // 
            // lblTotalStockValue
            // 
            lblTotalStockValue.AutoSize = true;
            lblTotalStockValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalStockValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblTotalStockValue.Location = new Point(20, 48);
            lblTotalStockValue.Name = "lblTotalStockValue";
            lblTotalStockValue.Size = new Size(38, 45);
            lblTotalStockValue.TabIndex = 1;
            lblTotalStockValue.Text = "0";
            // 
            // lblLowStockValue
            // 
            lblLowStockValue.AutoSize = true;
            lblLowStockValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblLowStockValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblLowStockValue.Location = new Point(20, 48);
            lblLowStockValue.Name = "lblLowStockValue";
            lblLowStockValue.Size = new Size(38, 45);
            lblLowStockValue.TabIndex = 1;
            lblLowStockValue.Text = "0";
            // 
            // lblTodayMovementsValue
            // 
            lblTodayMovementsValue.AutoSize = true;
            lblTodayMovementsValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTodayMovementsValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblTodayMovementsValue.Location = new Point(20, 48);
            lblTodayMovementsValue.Name = "lblTodayMovementsValue";
            lblTodayMovementsValue.Size = new Size(38, 45);
            lblTodayMovementsValue.TabIndex = 1;
            lblTodayMovementsValue.Text = "0";
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.AutoSize = true;
            lblSummaryTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSummaryTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblSummaryTitle.Location = new Point(25, 20);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(117, 25);
            lblSummaryTitle.TabIndex = 1;
            lblSummaryTitle.Text = "在庫サマリー";
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(lblSummaryTitle);
            Controls.Add(tlpSummary);
            Name = "DashboardControl";
            Size = new Size(900, 600);
            tlpSummary.ResumeLayout(false);
            pnlProductCount.ResumeLayout(false);
            pnlProductCount.PerformLayout();
            pnlTotalStock.ResumeLayout(false);
            pnlTotalStock.PerformLayout();
            pnlTodayMovements.ResumeLayout(false);
            pnlTodayMovements.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpSummary;
        private Panel pnlProductCount;
        private Panel pnlTotalStock;
        private Panel pnlTodayMovements;
        private Panel pnlLowStock;
        private Label lblProductCountValue;
        private Label lblProductCountTitle;
        private Label lblTotalStockValue;
        private Label lblTotalStockTitle;
        private Label lblTodayMovementsValue;
        private Label lblTodayMovementsTitle;
        private Label lblLowStockValue;
        private Label lblLowStockTitle;
        private Label lblSummaryTitle;
    }
}
