using System;

namespace DigitalWare.Core.DTOs.Customer
{
    public class CustomerInsertDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public string DocumentNumber { get; set; }
    }
}