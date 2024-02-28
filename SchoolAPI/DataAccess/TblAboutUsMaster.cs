using System;
using System.Collections.Generic;

namespace SchoolAPI.DataAccess
{
    public partial class TblAboutUsMaster
    {
        public int Id { get; set; }
        public string? AboutUsHeading { get; set; }
        public string? Descreption { get; set; }
        public string? AboutsFileName { get; set; }
        public string? AboutsFilePath { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? AddedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
