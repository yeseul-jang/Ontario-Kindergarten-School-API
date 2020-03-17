using System;
using System.Collections.Generic;

namespace APIProjectClient
{
    public partial class EnrolmentBySchool
    {
        public int EnrolmentBySchoolId { get; set; }
        public string BoardNumber { get; set; }
        public string BoardName { get; set; }
        public int? SchoolNumber { get; set; }
        public string SchoolName { get; set; }
        public string SchoolLevel { get; set; }
        public string SchoolType { get; set; }
        public string SchoolLanguage { get; set; }
        public int? Enrolment { get; set; }

        public override string ToString()
        {
            return $"SchoolNumber: {SchoolNumber}, SchoolName: {SchoolName}, SchoolLevel: {SchoolLevel}, " +
                $"SchoolType: {SchoolType}, SchoolLanguage: {SchoolLanguage}, Enrolment: {Enrolment}";
        }
    }
}
