using APIProjectClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Project.Services
{
    public interface IEnrolmentByGenderRepository
    {
        Task<IEnumerable<EnrolmentByGender>> GetAll();
        Task<EnrolmentByGender> GetById(int id);
    }
}
