using System;
using System.Collections.Generic;

namespace DigitalWare.Core.Entities
{
    public class CustomerInvoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Total { get; set; }
        public DateTime Created { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<CustomerInvoiceConcept> Concepts { get; set; }
    }
}