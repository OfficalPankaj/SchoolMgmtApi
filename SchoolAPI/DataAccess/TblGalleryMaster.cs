using System;
using System.Collections.Generic;

namespace SchoolAPI.DataAccess
{
    public partial class TblGalleryMaster
    {
        public int Id { get; set; }
        public string? GalleryPunchLine { get; set; }
        public string? GalleryFileName { get; set; }
        public string? GalleryFilePath { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? AddedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
