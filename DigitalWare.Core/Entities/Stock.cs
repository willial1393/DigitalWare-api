using System;

namespace DigitalWare.Core.Entities
{
    public class Stock
    {
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int? Quantity { get; set; }
        public int? TotalQuantity { get; set; }
        public int? UnitPrice { get; set; }
        public int? Total { get; set; }
        public DateTime? Created { get; set; }
    }
}