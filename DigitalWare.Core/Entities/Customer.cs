using System;

namespace DigitalWare.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentType { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}