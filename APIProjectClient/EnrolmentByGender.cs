using System;
using System.Collections.Generic;

namespace APIProjectClient
{
    public partial class EnrolmentByGender
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

        public override string ToString()
        {
            return $"BoardNumber: {BoardNumber}, BoardName: {BoardName}, TotalMaleEnrolment: {TotalMaleEnrolment}, TotalFemaleEnrolment: {TotalFemaleEnrolment}";
        }
    }
}
