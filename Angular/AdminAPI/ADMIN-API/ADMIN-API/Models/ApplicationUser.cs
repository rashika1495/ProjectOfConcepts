using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADMINAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AvatarURL { get; set; }
        public string DateRegistered { get; set; }
        public string Position { get; set; }
        public string NickName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserType { get; set; }
    }
}
