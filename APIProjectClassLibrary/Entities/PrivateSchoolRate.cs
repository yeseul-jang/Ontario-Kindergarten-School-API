using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIProjectClassLibrary.Entities
{
    public partial class PrivateSchoolRate
    {
        [Key]
        public int PrivateSchoolRateId { get; set; }
        public int? SchoolNumber { get; set; }
        public string StudentNumber { get; set; }
        public string StudentName { get; set; }
        public int? Rate { get; set; }

        public PrivateSchool SchoolNumberNavigation { get; set; }
    }
}
