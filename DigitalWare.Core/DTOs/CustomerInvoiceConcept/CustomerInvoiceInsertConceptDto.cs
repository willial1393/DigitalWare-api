namespace DigitalWare.Core.DTOs.CustomerInvoiceConcept
{
    public class CustomerInvoiceInsertConceptDto
    {
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public decimal Total { get; set; }
    }
}