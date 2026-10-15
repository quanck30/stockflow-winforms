using System;
using System.Collections.Generic;
using System.Text;

namespace StockFlow.Models
{
    /// <summary>
    /// 商品の基本情報と在庫情報を管理するモデル。
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string ProductCode { get; set; } = "";
        public string ProductName { get; set; } = "";
        public string Category { get; set; } = "";
        public int StockQuantity { get; set; } 
        public int MinimumStock { get; set; } 
        public int UnitPrice {  get; set; }


    }
}
