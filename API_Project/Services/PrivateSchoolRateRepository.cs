using APIProjectClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Project.Services
{
    public class PrivateSchoolRateRepository : IPrivateSchoolRateRepository
    {
        private API_ProjectContext _context;
        public PrivateSchoolRateRepository(API_ProjectContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PrivateSchoolRate>> GetAllRates()
        {
            var result = _context.PrivateSchoolRate.OrderBy(r => r.Rate);

            return await result.ToListAsync();
        }

        public async Task<PrivateSchoolRate> GetRateById(int privateSchoolRateId)
        {
            IQueryable<PrivateSchoolRate> result;

            result = _context.PrivateSchoolRate.Where(r => r.PrivateSchoolRateId == privateSchoolRateId);

            return await result.FirstOrDefaultAsync();
        }

        public void AddRate(PrivateSchoolRate rate)
        {
            _context.PrivateSchoolRate.Add(rate);
        }

        public void DeleteRate(PrivateSchoolRate rate)
        {
            IQueryable<PrivateSchoolRate> result;

            result = _context.PrivateSchoolRate.Where(r => r.PrivateSchoolRateId == rate.PrivateSchoolRateId);

            _context.PrivateSchoolRate.Remove(result.FirstOrDefault());
        }

        public async Task<bool> Save()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
