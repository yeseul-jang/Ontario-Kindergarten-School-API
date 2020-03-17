using APIProjectClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Project.Services
{
    public interface IPrivateSchoolRateRepository
    {
        Task<IEnumerable<PrivateSchoolRate>> GetAllRates(); // getAll
        Task<PrivateSchoolRate> GetRateById(int privateSchoolRateId); // getById
        void AddRate(PrivateSchoolRate rate); // post
        void DeleteRate(PrivateSchoolRate rate); // delete

        Task<bool> Save();
    }
}
