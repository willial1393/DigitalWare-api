using System;

namespace DigitalWare.Core.Entities
{
    public class Stock
    {
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Int16? Quantity { get; set; }
        public Int16? TotalQuantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Total { get; set; }
        public DateTime? Created { get; set; }
    }
}