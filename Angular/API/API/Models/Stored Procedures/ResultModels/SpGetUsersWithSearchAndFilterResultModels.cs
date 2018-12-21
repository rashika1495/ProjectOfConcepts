using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Stored_Procedures.ResultModels
{
    public class SpGetUsersWithSearchAndFilterResultModels
    {
        public long RowNumber { get; set; }
        [Key]
        public int Id { get; set; }
        public string AspnetUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }
        public bool IsActive { get; set; }
        public int RecordsTotal { get; set; }
    }
}
