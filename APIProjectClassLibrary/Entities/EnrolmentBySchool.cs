using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIProjectClassLibrary.Entities
{
    public partial class EnrolmentBySchool
    {
        [Key]
        public int EnrolmentBySchoolId { get; set; }
        public string BoardNumber { get; set; }
        public string BoardName { get; set; }
        public int? SchoolNumber { get; set; }
        public string SchoolName { get; set; }
        public string SchoolLevel { get; set; }
        public string SchoolType { get; set; }
        public string SchoolLanguage { get; set; }
        public int? Enrolment { get; set; }
    }
}
