using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIProjectClassLibrary.Entities
{
    public partial class EnrolmentByGender
    {
        [Key]
        public int EnrolmentByGenderId { get; set; }
        public string BoardNumber { get; set; }
        public string BoardName { get; set; }
        public string ElementaryMaleEnrolment { get; set; }
        public string ElementaryFemaleEnrolment { get; set; }
        public string SecondaryMaleEnrolment { get; set; }
        public string SecondaryFemaleEnrolment { get; set; }
        public string TotalMaleEnrolment { get; set; }
        public string TotalFemaleEnrolment { get; set; }
    }
}
