using APIProjectClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Project.Services
{
    public interface IPublicSchoolRepository
    {
        Task<IEnumerable<PublicSchool>> GetPublicSchoolsAsync();
        Task<PublicSchool> GetPublicSchoolByIdAsync(int publicSchoolId);
    }
}
