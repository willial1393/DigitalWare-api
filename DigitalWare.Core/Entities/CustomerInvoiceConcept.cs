namespace DigitalWare.Core.Entities
{
    public class CustomerInvoiceConcept
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public decimal Total { get; set; }
        public Product Product { get; set; }
    }
}