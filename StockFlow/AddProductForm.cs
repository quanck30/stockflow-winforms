using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using StockFlow.Repositories;
using StockFlow.Models;

namespace StockFlow
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 商品コードの未入力を確認する
            if (string.IsNullOrWhiteSpace(txtProductCode.Text))
            {
                MessageBox.Show("商品コードを入力してください。",
            "入力エラー",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
                
                txtProductCode.Focus();
                return;
            }

            // 商品名の未入力を確認する
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show(
           "商品名を入力してください。",
           "入力エラー",
           MessageBoxButtons.OK,
           MessageBoxIcon.Warning);
                txtProductName.Focus();
                return;
            }
            // カテゴリが選択されているか確認する
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "カテゴリを選択してください。",
                    "入力エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbCategory.Focus();
                return;
            }
            // 商品コードの前後にある空白を除去する
            string productCode = txtProductCode.Text.Trim();
            // 商品コードの重複を確認する
            if (ProductRepository.ExistsByCode(productCode))
            {
                MessageBox.Show(
                    "この商品コードは既に登録されています。",
                    "入力エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtProductCode.Focus();
                return;
            }
            // 単価が0円以下の場合は登録を許可しない
            if (nudUnitPrice.Value <= 0)
            {
                MessageBox.Show(
                    "単価は1円以上を入力してください。",
                    "入力エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                nudUnitPrice.Focus();
                return;
            }
            //  入力された情報から商品オブジェクトを作成する
            Product product = new()
            {
                ProductCode = productCode,
                ProductName = txtProductName.Text,
                Category = cmbCategory.SelectedItem!.ToString()!,
                StockQuantity = (int)nudStockQuantity.Value,
                MinimumStock = (int)nudMinimumStock.Value,
                UnitPrice = (int)nudUnitPrice.Value,
            };
            try
            {
                //  商品をリポジトリに登録する
                ProductRepository.Add(product);

                // 登録成功を通知してダイアログを閉じる
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) {
                     MessageBox.Show(
                                ex.Message,
                               "登録エラー",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning
                      );
            }
        }
    }
}
