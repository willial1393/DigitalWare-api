using System;

namespace DigitalWare.Core.DTOs
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentType { get; set; }
    }
}