using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIProjectClassLibrary.Entities
{
    public partial class PublicSchool
    {
        public int PublicSchoolId { get; set; }
        public string Region { get; set; }
        public string BoardNumber { get; set; }
        public string BoardName { get; set; }
        public string BoardType { get; set; }
        public string BoardLanguage { get; set; }
        [Key]
        public double? SchoolNumber { get; set; }
        public string SchoolName { get; set; }
        public string SchoolLevel { get; set; }
        public string SchoolLanguage { get; set; }
        public string SchoolType { get; set; }
        public string SchoolSpecialConditionsCode { get; set; }
        public string Suite { get; set; }
        public string PoBox { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string GradeRange { get; set; }
        public string DateOpen { get; set; }
        public string SchoolEmail { get; set; }
        public string SchoolWebsite { get; set; }
        public string BoardWebsite { get; set; }
    }
}
