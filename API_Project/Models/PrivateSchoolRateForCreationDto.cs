using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Project.Models
{
    public class PrivateSchoolRateForCreationDto
    {
        public int? SchoolNumber { get; set; }
        public string StudentNumber { get; set; }
        public string StudentName { get; set; }
        public int? Rate { get; set; }
    }
}
