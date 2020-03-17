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
    public class EnrolmentBySchoolController: ControllerBase
    {
        private IEnrolmentBySchoolRepository _enrolmentBySchoolRepository;
        private readonly IMapper _mapper;


        public EnrolmentBySchoolController(IEnrolmentBySchoolRepository enrolmentBySchoolRepository, IMapper mapper)
        {
            _enrolmentBySchoolRepository = enrolmentBySchoolRepository;
            _mapper = mapper;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<EnrolmentBySchool>> GetAll()
        {
            var entity = await _enrolmentBySchoolRepository.GetAll();

            var results = _mapper.Map<IEnumerable<EnrolmentBySchoolDto>>(entity);

            return Ok(results);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EnrolmentBySchool>> GetById(int id)
        {
            var entity = await _enrolmentBySchoolRepository.GetById(id);

            if (entity == null)
            {
                return NotFound();
            }

            var Result = _mapper.Map<EnrolmentBySchoolDto>(entity);
            return Ok(Result);
        }
    }
}
