using System;

namespace DigitalWare.Core.DTOs.Product
{
    public class ProductRemoveUnitsDto
    {
        public int ProductId { get; set; }
        public Int16 Units { get; set; }
        public Int16 UnitPrice { get; set; }
    }
}