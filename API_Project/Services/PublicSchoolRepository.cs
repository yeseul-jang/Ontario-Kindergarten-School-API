using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIProjectClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Project.Services
{
    public class PublicSchoolRepository : IPublicSchoolRepository
    {
        
        private API_ProjectContext _context;
        public PublicSchoolRepository(API_ProjectContext context)
        {
            _context = context;
        }        

        public async Task<IEnumerable<PublicSchool>> GetPublicSchoolsAsync()
        {
            var result = _context.PublicSchool.OrderBy(ps => ps.BoardName);
            return await result.ToListAsync();
        }

        public async Task<PublicSchool> GetPublicSchoolByIdAsync(int publicSchoolId)
        {
            IQueryable<PublicSchool> result;
            result = _context.PublicSchool.Where(ps => ps.PublicSchoolId == publicSchoolId);

            return await result.FirstOrDefaultAsync();
        }
    }
}
