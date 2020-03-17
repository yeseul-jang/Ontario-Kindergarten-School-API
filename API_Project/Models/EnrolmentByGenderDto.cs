using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Project.Models
{
    public class EnrolmentByGenderDto
    {
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
