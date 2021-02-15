using DigitalWare.Core.DTOs.Product;

namespace DigitalWare.Core.DTOs.CustomerInvoiceConcept
{
    public class CustomerInvoiceConceptDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public decimal Total { get; set; }
        public ProductDto Product { get; set; }
    }
}