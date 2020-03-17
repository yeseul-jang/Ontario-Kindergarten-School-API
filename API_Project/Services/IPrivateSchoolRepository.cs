using APIProjectClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Project.Services
{
    public interface IPrivateSchoolRepository
    {
        // private school
        Task<bool> PrivateSchoolExists(int schoolNumber);
        Task<IEnumerable<PrivateSchool>> GetPrivateSchoolsAsync();
        Task<PrivateSchool> GetPrivateSchoolByIdAsync(int schoolNumber);
        Task<PrivateSchool> GetPrivateSchoolByIdAsync(int schoolNumber, bool includeRate);
        Task<IEnumerable<PrivateSchoolRate>> GetRatesForSchool(int schoolNumber);
        Task<PrivateSchoolRate> GetRatesForSchool(int schoolNumber, int rateId);
        Task AddPrivateSchoolAsync(int schoolNumber, PrivateSchoolRate privateSchoolRate);
        void DeletePrivateSchoolRate(PrivateSchoolRate privateSchoolRate);
        
        Task<bool> Save();
    }
}
