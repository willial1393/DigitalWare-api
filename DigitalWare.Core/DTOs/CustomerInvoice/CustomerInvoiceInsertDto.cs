using System.Collections.Generic;
using DigitalWare.Core.DTOs.CustomerInvoiceConcept;

namespace DigitalWare.Core.DTOs.CustomerInvoice
{
    public class CustomerInvoiceInsertDto
    {
        public int CustomerId { get; set; }
        public decimal Total { get; set; }
        public IEnumerable<CustomerInvoiceInsertConceptDto> Concepts { get; set; }
    }
}