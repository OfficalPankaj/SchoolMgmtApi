using System;
using System.Collections.Generic;

namespace SchoolAPI.DataAccess
{
    public partial class TblAdminLogin
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? UserPassword { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsLocked { get; set; }
        public bool? IsDeleted { get; set; }
        public string? AddedBy { get; set; }
        public DateTime? AddedOn { get; set; }
    }
}
