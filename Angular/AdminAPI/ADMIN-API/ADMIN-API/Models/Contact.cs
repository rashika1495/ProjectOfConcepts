using System;
using System.Collections.Generic;

namespace ADMINAPI.Models
{
    public partial class Contact
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte Gender { get; set; }
        public DateTime? Birth { get; set; }
        public string Techno { get; set; }
        public string Message { get; set; }
    }
}
