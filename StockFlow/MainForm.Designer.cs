namespace StockFlow
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            pnlSeparator = new Panel();
            lblAppSubtitle = new Label();
            btnHistory = new Button();
            btnStockOut = new Button();
            btnStockIn = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            lblAppName = new Label();
            pnlHeader = new Panel();
            pnlHeaderSeparator = new Panel();
            lblCurrentDate = new Label();
            lblPageTitle = new Label();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(32, 44, 61);
            pnlSidebar.Controls.Add(pnlSeparator);
            pnlSidebar.Controls.Add(lblAppSubtitle);
            pnlSidebar.Controls.Add(btnHistory);
            pnlSidebar.Controls.Add(btnStockOut);
            pnlSidebar.Controls.Add(btnStockIn);
            pnlSidebar.Controls.Add(btnProducts);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblAppName);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 711);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.FromArgb(71, 85, 105);
            pnlSeparator.Location = new Point(20, 85);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(180, 1);
            pnlSeparator.TabIndex = 7;
            // 
            // lblAppSubtitle
            // 
            lblAppSubtitle.AutoSize = true;
            lblAppSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblAppSubtitle.Location = new Point(22, 62);
            lblAppSubtitle.Name = "lblAppSubtitle";
            lblAppSubtitle.Size = new Size(92, 15);
            lblAppSubtitle.TabIndex = 6;
            lblAppSubtitle.Text = "在庫管理システム";
            // 
            // btnHistory
            // 
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 10F);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(10, 300);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(200, 45);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "入出庫履歴";
            btnHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnStockOut
            // 
            btnStockOut.FlatAppearance.BorderSize = 0;
            btnStockOut.FlatStyle = FlatStyle.Flat;
            btnStockOut.Font = new Font("Segoe UI", 10F);
            btnStockOut.ForeColor = Color.White;
            btnStockOut.Location = new Point(10, 250);
            btnStockOut.Name = "btnStockOut";
            btnStockOut.Size = new Size(200, 45);
            btnStockOut.TabIndex = 4;
            btnStockOut.Text = "出庫管理";
            btnStockOut.TextAlign = ContentAlignment.MiddleLeft;
            btnStockOut.UseVisualStyleBackColor = true;
            // 
            // btnStockIn
            // 
            btnStockIn.FlatAppearance.BorderSize = 0;
            btnStockIn.FlatStyle = FlatStyle.Flat;
            btnStockIn.Font = new Font("Segoe UI", 10F);
            btnStockIn.ForeColor = Color.White;
            btnStockIn.Location = new Point(10, 200);
            btnStockIn.Name = "btnStockIn";
            btnStockIn.Size = new Size(200, 45);
            btnStockIn.TabIndex = 3;
            btnStockIn.Text = "入庫管理";
            btnStockIn.TextAlign = ContentAlignment.MiddleLeft;
            btnStockIn.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 10F);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(10, 150);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(200, 45);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "商品管理";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 100);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "ダッシュボード";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(20, 25);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(128, 32);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "StockFlow";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pnlHeaderSeparator);
            pnlHeader.Controls.Add(lblCurrentDate);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(220, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(964, 65);
            pnlHeader.TabIndex = 1;
            // 
            // pnlHeaderSeparator
            // 
            pnlHeaderSeparator.Dock = DockStyle.Bottom;
            pnlHeaderSeparator.ForeColor = Color.FromArgb(226, 232, 240);
            pnlHeaderSeparator.Location = new Point(0, 64);
            pnlHeaderSeparator.Name = "pnlHeaderSeparator";
            pnlHeaderSeparator.Size = new Size(964, 1);
            pnlHeaderSeparator.TabIndex = 2;
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentDate.Font = new Font("Segoe UI", 10F);
            lblCurrentDate.ForeColor = Color.FromArgb(100, 116, 139);
            lblCurrentDate.Location = new Point(850, 10);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(100, 25);
            lblCurrentDate.TabIndex = 1;
            lblCurrentDate.Text = "2026/10/08";
            lblCurrentDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblPageTitle.Location = new Point(25, 18);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(138, 30);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "ダッシュボード";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(245, 247, 250);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 65);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(964, 646);
            pnlContent.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 711);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1000, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockFlow - 在庫管理システム";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Panel pnlContent;
        private Button btnDashboard;
        private Label lblAppName;
        private Button btnHistory;
        private Button btnStockOut;
        private Button btnStockIn;
        private Button btnProducts;
        private Label lblAppSubtitle;
        private Panel pnlSeparator;
        private Label lblPageTitle;
        private Panel pnlHeaderSeparator;
        private Label lblCurrentDate;
        private Label label1;
    }
}
