using System;
using System.Collections.Generic;
using System.Text;

namespace ADMINAPI.DTO
{
    public class UserSearchFilterDTO
    {
        public string SearchText { get; set; }
        public int? PageSize { get; set; }
        public int? PageNumber { get; set; }
        public bool? IsActive { get; set; }
    }
}
