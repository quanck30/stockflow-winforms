using StockFlow.Models;
using StockFlow.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockFlow
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
            var products = ProductRepository.GetAll();
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = products;
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // データ行以外は処理しない
            if (e.RowIndex < 0)
            {
                return;
            }
            // 行に紐づく商品データを取得する
            if (dgvProducts.Rows[e.RowIndex].DataBoundItem is not Product product)
            {
                return;
            }
            if (product.StockQuantity < product.MinimumStock)
            {
                e.CellStyle.BackColor = Color.FromArgb(254, 226, 226);
                e.CellStyle.ForeColor = Color.FromArgb(153, 27, 27);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using AddProductForm form = new();
            form.ShowDialog(this.FindForm());
        }
    }
}
