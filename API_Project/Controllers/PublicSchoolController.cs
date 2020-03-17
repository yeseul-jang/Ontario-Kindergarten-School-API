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
    public class PublicSchoolController : ControllerBase
    {
        
        private IPublicSchoolRepository _apiProjectRepository;
        private readonly IMapper _mapper;

        
        public PublicSchoolController(IPublicSchoolRepository apiProjectRepository, IMapper mapper)
        {
            _apiProjectRepository = apiProjectRepository;
            _mapper = mapper;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<PublicSchool>> GetAllPublicSchools()
        {
            var publicSchoolEntities = await _apiProjectRepository.GetPublicSchoolsAsync();

            var results = _mapper.Map<IEnumerable<PublicSchoolDto>>(publicSchoolEntities);

            return Ok(results);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PublicSchool>> GetPublicSchoolById(int id)
        {
            var publicSchool = await _apiProjectRepository.GetPublicSchoolByIdAsync(id);

            if (publicSchool == null)
            {
                return NotFound();
            }            

            var publicSchoolResult = _mapper.Map<PublicSchoolDto>(publicSchool);
            return Ok(publicSchoolResult);
        }
        
    }
}
