using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIProjectClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Project.Services
{
    public class PrivateSchoolRepository : IPrivateSchoolRepository
    {        
        private API_ProjectContext _context;
        public PrivateSchoolRepository(API_ProjectContext context)
        {
            _context = context;
        }

        public async Task<bool> PrivateSchoolExists(int schoolNumber)
        {
            return await _context.PrivateSchool.AnyAsync(ps => ps.SchoolNumber == schoolNumber);
        }

        public async Task<IEnumerable<PrivateSchool>> GetPrivateSchoolsAsync()
        {
            var result = _context.PrivateSchool.OrderBy(ps => ps.Tuition);
            return await result.ToListAsync();
        }

        public async Task<PrivateSchool> GetPrivateSchoolByIdAsync(int schoolNumber)
        {
            IQueryable<PrivateSchool> result;

            result = _context.PrivateSchool.Where(p => p.SchoolNumber == schoolNumber);

            PrivateSchool privateSchool = await result.FirstOrDefaultAsync();

            IQueryable<PrivateSchoolRate> privateSchoolRates = _context.PrivateSchoolRate.Where(p => p.SchoolNumber == schoolNumber);

            if (privateSchoolRates.Count() != 0)
            {
                foreach (var p in privateSchoolRates)
                {
                    privateSchool.PrivateSchoolRates.Add(p);
                }

            }
            return privateSchool;
        }

        public async Task<PrivateSchool> GetPrivateSchoolByIdAsync(int schoolNumber, bool includeRate)
        {
            IQueryable<PrivateSchool> result;

            if (includeRate)
            {
                result = _context.PrivateSchool.Include(p => p.PrivateSchoolRates)
                    .Where(p => p.SchoolNumber == schoolNumber);
            }
            else result = _context.PrivateSchool.Where(p => p.SchoolNumber == schoolNumber);

            return await result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PrivateSchoolRate>> GetRatesForSchool(int schoolNumber)
        {
            IQueryable<PrivateSchoolRate> result = _context.PrivateSchoolRate.Where(p => p.SchoolNumber == schoolNumber);
            return await result.ToListAsync();
        }

        public async Task<PrivateSchoolRate> GetRatesForSchool(int schoolNumber, int privateSchoolRateId)
        {
            IQueryable<PrivateSchoolRate> result = _context.PrivateSchoolRate.Where(p => p.SchoolNumber == schoolNumber && p.PrivateSchoolRateId == privateSchoolRateId);
            return await result.FirstOrDefaultAsync();
        }

        public async Task AddPrivateSchoolAsync(int schoolNumber, PrivateSchoolRate privateSchoolRate)
        {
            var privateSchool = await GetPrivateSchoolByIdAsync(schoolNumber, false);
            privateSchoolRate.SchoolNumber = privateSchool.SchoolNumber;
            privateSchool.PrivateSchoolRates.Add(privateSchoolRate);
        }

        public void DeletePrivateSchoolRate(PrivateSchoolRate privateSchoolRate)
        {
           _context.PrivateSchoolRate.Remove(privateSchoolRate);
        }

        public async Task<bool> Save()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
        
    }
}
