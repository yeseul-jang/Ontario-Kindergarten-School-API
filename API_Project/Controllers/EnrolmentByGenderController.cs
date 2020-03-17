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
    public class EnrolmentByGenderController : ControllerBase
    {
        private IEnrolmentByGenderRepository _enrolmentByGenderRepository;
        private readonly IMapper _mapper;


        public EnrolmentByGenderController(IEnrolmentByGenderRepository enrolmentByGenderRepository, IMapper mapper)
        {
            _enrolmentByGenderRepository = enrolmentByGenderRepository;
            _mapper = mapper;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<EnrolmentByGender>> GetAll()
        {
            var entity = await _enrolmentByGenderRepository.GetAll();

            var results = _mapper.Map<IEnumerable<EnrolmentByGenderDto>>(entity);

            return Ok(results);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EnrolmentByGender>> GetById(int id)
        {
            var entity = await _enrolmentByGenderRepository.GetById(id);

            if (entity == null)
            {
                return NotFound();
            }

            var Result = _mapper.Map<EnrolmentByGenderDto>(entity);
            return Ok(Result);
        }
    }
}
