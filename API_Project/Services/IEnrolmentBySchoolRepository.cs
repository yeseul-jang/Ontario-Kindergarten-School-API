using APIProjectClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Project.Services
{
    public interface IEnrolmentBySchoolRepository
    {
        Task<IEnumerable<EnrolmentBySchool>> GetAll();
        Task<EnrolmentBySchool> GetById(int id);
    }
}
