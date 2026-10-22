using System.ComponentModel;
using StockFlow.Models;

namespace StockFlow.Repositories
{
    /// <summary>
    /// 商品データをメモリ上で管理するリポジトリ。
    /// </summary>
    public static class ProductRepository
    {
        // アプリケーション内で共有する商品一覧
        private static readonly BindingList<Product> _products = new()
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

        /// <summary>
        /// 商品一覧を取得する。
        /// </summary>
        public static BindingList<Product> GetAll()
        {
            return _products;
        }

        /// <summary>
        /// 指定された商品コードが既に存在するか確認する。
        /// </summary>
        public static bool ExistsByCode(string productCode)
        {
            return _products.Any(product =>
                string.Equals(
                    product.ProductCode,
                    productCode,
                    StringComparison.OrdinalIgnoreCase
                ));
        }

        /// <summary>
        /// 新しい商品を商品一覧に追加する
        /// </summary>
        /// <param name="product">追加する商品</param>
        public static void Add(Product product) {
            // 商品コードの重複登録を防ぐ
            if (ExistsByCode(product.ProductCode)){
                throw new Exception(" この商品コードは既に登録されています。");
            }

            // 既存の商品IDと重複しないIDを採番する
            product.Id = _products.Count ==  0 ? 1: _products.Max(p=> p.Id) + 1;

            // 商品一覧に追加する
            _products.Add(product);
          }
    }
}