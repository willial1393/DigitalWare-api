using System;
using System.Collections.Generic;
using DigitalWare.Core.DTOs.Customer;
using DigitalWare.Core.DTOs.CustomerInvoiceConcept;

namespace DigitalWare.Core.DTOs.CustomerInvoice
{
    public class CustomerInvoiceDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Total { get; set; }
        public DateTime Created { get; set; }
        public CustomerDto Customer { get; set; }
        public IEnumerable<CustomerInvoiceConceptDto> Concepts { get; set; }
    }
}