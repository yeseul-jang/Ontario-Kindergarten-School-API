using System;
using System.Collections.Generic;

namespace APIProjectClient
{
    public partial class PrivateSchoolRate
    {
        public int PrivateSchoolRateId { get; set; }
        public int? SchoolNumber { get; set; }
        public string StudentNumber { get; set; }
        public string StudentName { get; set; }
        public int? Rate { get; set; }

        public override string ToString()
        {
            return $"PrivateSchoolRateId: {PrivateSchoolRateId}, SchoolNumber: {SchoolNumber}, " +
                $"StudentNumber: {StudentNumber}, StudentName: {StudentName}, Rate: {Rate}";
        }
    }
}
