using System;
using DigitalWare.Core.DTOs.Product;

namespace DigitalWare.Core.DTOs
{
    public class StockHistoryDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Type { get; set; }
        public Int16 Quantity { get; set; }
        public Int16 TotalQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
        public DateTime Created { get; set; }
        public ProductDto Product { get; set; }
    }
}