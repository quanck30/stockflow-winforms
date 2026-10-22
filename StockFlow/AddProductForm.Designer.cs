namespace StockFlow
{
    partial class AddProductForm
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
            lblProductCode = new Label();
            lblProductName = new Label();
            lblCategory = new Label();
            lblStockQuantity = new Label();
            lblMiniumStock = new Label();
            lblUnitPrice = new Label();
            txtProductCode = new TextBox();
            txtProductName = new TextBox();
            cmbCategory = new ComboBox();
            nudStockQuantity = new NumericUpDown();
            nudMinimumStock = new NumericUpDown();
            nudUnitPrice = new NumericUpDown();
            btnCancel = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)nudStockQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinimumStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitPrice).BeginInit();
            SuspendLayout();
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font("Segoe UI", 10F);
            lblProductCode.Location = new Point(30, 25);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(68, 19);
            lblProductCode.TabIndex = 0;
            lblProductCode.Text = "商品コード";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10F);
            lblProductName.Location = new Point(30, 95);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(51, 19);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "商品名";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F);
            lblCategory.Location = new Point(30, 165);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(49, 19);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "カテゴリ";
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Font = new Font("Segoe UI", 10F);
            lblStockQuantity.Location = new Point(30, 235);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(51, 19);
            lblStockQuantity.TabIndex = 3;
            lblStockQuantity.Text = "在庫数";
            // 
            // lblMiniumStock
            // 
            lblMiniumStock.AutoSize = true;
            lblMiniumStock.Font = new Font("Segoe UI", 10F);
            lblMiniumStock.Location = new Point(30, 305);
            lblMiniumStock.Name = "lblMiniumStock";
            lblMiniumStock.Size = new Size(79, 19);
            lblMiniumStock.TabIndex = 4;
            lblMiniumStock.Text = "最低在庫数";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI", 10F);
            lblUnitPrice.Location = new Point(30, 375);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(79, 19);
            lblUnitPrice.TabIndex = 5;
            lblUnitPrice.Text = "単価（円）";
            // 
            // txtProductCode
            // 
            txtProductCode.Font = new Font("Segoe UI", 11F);
            txtProductCode.Location = new Point(30, 48);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(420, 27);
            txtProductCode.TabIndex = 6;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 11F);
            txtProductName.Location = new Point(30, 118);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(420, 27);
            txtProductName.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 11F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "文房具", "電子機器", "日用品", "その他" });
            cmbCategory.Location = new Point(30, 188);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(420, 28);
            cmbCategory.TabIndex = 8;
            // 
            // nudStockQuantity
            // 
            nudStockQuantity.Font = new Font("Segoe UI", 11F);
            nudStockQuantity.Location = new Point(30, 258);
            nudStockQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudStockQuantity.Name = "nudStockQuantity";
            nudStockQuantity.Size = new Size(420, 27);
            nudStockQuantity.TabIndex = 9;
            nudStockQuantity.ThousandsSeparator = true;
            // 
            // nudMinimumStock
            // 
            nudMinimumStock.Font = new Font("Segoe UI", 11F);
            nudMinimumStock.Location = new Point(30, 328);
            nudMinimumStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudMinimumStock.Name = "nudMinimumStock";
            nudMinimumStock.Size = new Size(420, 27);
            nudMinimumStock.TabIndex = 10;
            nudMinimumStock.ThousandsSeparator = true;
            // 
            // nudUnitPrice
            // 
            nudUnitPrice.Font = new Font("Segoe UI", 11F);
            nudUnitPrice.Location = new Point(30, 398);
            nudUnitPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudUnitPrice.Name = "nudUnitPrice";
            nudUnitPrice.Size = new Size(420, 27);
            nudUnitPrice.TabIndex = 11;
            nudUnitPrice.ThousandsSeparator = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(241, 245, 249);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(51, 65, 85);
            btnCancel.Location = new Point(210, 455);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 40);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "キャンセル";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(335, 455);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 40);
            btnSave.TabIndex = 13;
            btnSave.Text = "登録";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddProductForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(484, 511);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(nudUnitPrice);
            Controls.Add(nudMinimumStock);
            Controls.Add(nudStockQuantity);
            Controls.Add(cmbCategory);
            Controls.Add(txtProductName);
            Controls.Add(txtProductCode);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblMiniumStock);
            Controls.Add(lblStockQuantity);
            Controls.Add(lblCategory);
            Controls.Add(lblProductName);
            Controls.Add(lblProductCode);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProductForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "商品追加";
            ((System.ComponentModel.ISupportInitialize)nudStockQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinimumStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductCode;
        private Label lblProductName;
        private Label lblCategory;
        private Label lblStockQuantity;
        private Label lblMiniumStock;
        private Label lblUnitPrice;
        private TextBox txtProductCode;
        private TextBox txtProductName;
        private ComboBox cmbCategory;
        private NumericUpDown nudStockQuantity;
        private NumericUpDown nudMinimumStock;
        private NumericUpDown nudUnitPrice;
        private Button btnCancel;
        private Button btnSave;
    }
}