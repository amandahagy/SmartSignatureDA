using System;

namespace SmartSignature.Models
{
    public class PhoneNumber
    {
        public int PhoneNumberId { get; set; }
        public LocalPrefix PrefixId { get; set; }
        public int Number { get; set; }
        public User CaixaAccount { get; set; }
    }
}