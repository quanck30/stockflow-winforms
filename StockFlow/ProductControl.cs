using StockFlow.Models;
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
            List<Product> products = new()
            {
                 new Product
                {
                    Id = 1,
                    ProductCode = "P001",
                    ProductName = "ノート",
                    Category = "文房具",
                    StockQuantity = 120,
                    MinimumStock = 20,
                    UnitPrice = 250
                },
                new Product
                {
                    Id = 2,
                    ProductCode = "P002",
                    ProductName = "ボールペン",
                    Category = "文房具",
                    StockQuantity = 10,
                    MinimumStock = 30,
                    UnitPrice = 150
                }

            };
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
            if(product.StockQuantity < product.MinimumStock)
            {
                e.CellStyle.BackColor = Color.FromArgb(254, 226, 226);
                e.CellStyle.ForeColor = Color.FromArgb(153, 27, 27);
            }
        }
    }
}
