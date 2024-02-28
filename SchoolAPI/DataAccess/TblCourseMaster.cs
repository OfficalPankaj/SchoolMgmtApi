using System;
using System.Collections.Generic;

namespace SchoolAPI.DataAccess
{
    public partial class TblCourseMaster
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public string? CoursePunchLine { get; set; }
        public string? Descreption { get; set; }
        public string? CourseFileName { get; set; }
        public string? CourseFilePath { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? AddedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
