using API_Project.Models;
using API_Project.Services;
using APIProjectClassLibrary.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Project.Controllers
{
    [Route("api/[controller]")]
    public class PrivateSchoolController : ControllerBase
    {
        private IPrivateSchoolRepository _privateSchoolRepository;
        private readonly IMapper _mapper;


        public PrivateSchoolController(IPrivateSchoolRepository privateSchoolRepository, IMapper mapper)
        {
            _privateSchoolRepository = privateSchoolRepository;
            _mapper = mapper;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<PrivateSchool>> GetAllPrivateSchools()
        {
            var privateSchoolEntities = await _privateSchoolRepository.GetPrivateSchoolsAsync();

            var results = _mapper.Map<IEnumerable<PrivateSchoolWithoutRateDto>>(privateSchoolEntities);

            return Ok(results);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PrivateSchool>> GetPrivateSchoolById(int id, bool includeRate = false)
        {
            var privateSchool = await _privateSchoolRepository.GetPrivateSchoolByIdAsync(id, includeRate);

            if (privateSchool == null)
            {
                return NotFound();
            }

            if (includeRate)
            {
                var privateSchoolResult = _mapper.Map<PrivateSchoolDto>(privateSchool);
                return Ok(privateSchoolResult);
            }

            var privateSchoolWithoutRateResult = _mapper.Map<PrivateSchoolWithoutRateDto>(privateSchool);
            return Ok(privateSchoolWithoutRateResult);
        }
    }
}
