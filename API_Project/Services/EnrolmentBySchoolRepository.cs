using APIProjectClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Project.Services
{
    public class EnrolmentBySchoolRepository : IEnrolmentBySchoolRepository
    {
        private API_ProjectContext _context;
        public EnrolmentBySchoolRepository(API_ProjectContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EnrolmentBySchool>> GetAll()
        {
            var result = _context.EnrolmentBySchool.OrderBy(ps => ps.BoardNumber);
            return await result.ToListAsync();
        }

        public async Task<EnrolmentBySchool> GetById(int id)
        {
            IQueryable<EnrolmentBySchool> result;
            result = _context.EnrolmentBySchool.Where(ps => ps.EnrolmentBySchoolId == id);

            return await result.FirstOrDefaultAsync();
        }
    }
}
