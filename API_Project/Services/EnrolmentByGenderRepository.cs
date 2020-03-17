using APIProjectClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Project.Services
{
    public class EnrolmentByGenderRepository :IEnrolmentByGenderRepository
    {
        private API_ProjectContext _context;
        public EnrolmentByGenderRepository(API_ProjectContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EnrolmentByGender>> GetAll()
        {
            var result = _context.EnrolmentByGender.OrderBy(ps => ps.BoardNumber);
            return await result.ToListAsync();
        }

        public async Task<EnrolmentByGender> GetById(int id)
        {
            IQueryable<EnrolmentByGender> result;
            result = _context.EnrolmentByGender.Where(ps => ps.EnrolmentByGenderId == id);

            return await result.FirstOrDefaultAsync();
        }
    }
}
