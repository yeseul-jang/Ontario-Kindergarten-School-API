using System;
using System.Collections.Generic;

namespace APIProjectClient
{
    public partial class PrivateSchool
    {
        public int? PrivateSchoolId { get; set; }
        public string SchoolName { get; set; }
        public double? Suite { get; set; }
        public string PoBox { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string Fax { get; set; }
        public string Region { get; set; }
        public double? SchoolNumber { get; set; }
        public string SchoolWebsite { get; set; }
        public string SchoolLevel { get; set; }
        public string SchoolSpecialConditionsCode { get; set; }
        public string OssdCreditsOffered { get; set; }
        public string ProgramType { get; set; }
        public string AssociationMembership { get; set; }
        public double? Tuition { get; set; }

        public override string ToString()
        {
            return $"SchoolNumber: {SchoolNumber}, SchoolName: {SchoolName}, SchoolLevel: {SchoolLevel}, " +
                $"Address:{StreetAddress}{City}{Province}{PostalCode}, TelephoneNumber: {TelephoneNumber}, Tuition: {Tuition}";
        }
    }
}
