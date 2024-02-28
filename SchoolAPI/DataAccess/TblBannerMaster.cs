using System;
using System.Collections.Generic;

namespace SchoolAPI.DataAccess
{
    public partial class TblBannerMaster
    {
        public int Id { get; set; }
        public string? BannerHeading { get; set; }
        public string? BannerImage { get; set; }
        public string? BannerPath { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? AddedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
