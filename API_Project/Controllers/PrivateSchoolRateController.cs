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
    [Route("api/privateschool")]
    public class PrivateSchoolRateController : ControllerBase
    {
        private IPrivateSchoolRateRepository _privateSchoolRateRepository;
        private IPrivateSchoolRepository _privateSchoolRepository;
        private readonly IMapper _mapper;

        public PrivateSchoolRateController(IPrivateSchoolRateRepository privateSchoolRateRepository, IPrivateSchoolRepository privateSchoolRepository, IMapper mapper)
        {
            _privateSchoolRateRepository = privateSchoolRateRepository;
            _privateSchoolRepository = privateSchoolRepository;
            _mapper = mapper;
        }

        [HttpGet("privateschoolrate")]
        public async Task<ActionResult<PrivateSchoolRate>> GetAllPrivateSchoolRate()
        {
            var allRates = await _privateSchoolRateRepository.GetAllRates();
            var result = _mapper.Map<IEnumerable<PrivateSchoolRateDto>>(allRates);
            return Ok(result);
        }

        [HttpGet("{schoolNumber}/privateschoolrate")]
        public async Task<ActionResult<PrivateSchoolRate>> GetRateById(int schoolNumber)
        {
            if (!(await _privateSchoolRepository.PrivateSchoolExists(schoolNumber)))
            {
                return NotFound();
            }

            var ratesForSchool = await _privateSchoolRepository.GetRatesForSchool(schoolNumber);
            var ratesForSchoolResults = _mapper.Map<IEnumerable<PrivateSchoolRateDto>>(ratesForSchool);

            return Ok(ratesForSchoolResults);
        }

        [HttpGet("{schoolNumber}/privateschoolrate/{id}")]
        public async Task<ActionResult<PrivateSchoolRate>> GetRate(int schoolNumber, int id)
        {
            if (!await _privateSchoolRepository.PrivateSchoolExists(schoolNumber))
            {
                return NotFound();
            }

            var rate = await _privateSchoolRepository.GetRatesForSchool(schoolNumber, id);

            if (rate == null)
            {
                return NotFound();
            }

            var rateResult = _mapper.Map<PrivateSchoolRateDto>(rate);
            return Ok(rateResult);
        }

        // POST api/<controller>
        [HttpPost("{schoolNumber}/privateschoolrate")]
        public async Task<ActionResult<PrivateSchoolRateDto>> AddRate(int schoolNumber, [FromBody]PrivateSchoolRateForCreationDto rate)
        {
            
            if (rate == null) return BadRequest();

            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!await _privateSchoolRepository.PrivateSchoolExists(schoolNumber)) return NotFound();

            var finalRate = _mapper.Map<PrivateSchoolRate>(rate);

            await _privateSchoolRepository.AddPrivateSchoolAsync(schoolNumber, finalRate);


            if (!await _privateSchoolRepository.Save())
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }

            var createdRateToReturn = _mapper.Map<PrivateSchoolRateDto>(finalRate);

            return CreatedAtAction("GetRate", new { schoolNumber = schoolNumber, id = createdRateToReturn.PrivateSchoolRateId }, createdRateToReturn);
            

        }

        // PUT api/<controller>/5
        [HttpPut("{schoolNumber}/privateschoolrate/{id}")]
        public async Task<ActionResult> UpdateRate(int schoolNumber, int id, [FromBody] PrivateSchoolRateForUpdateDto rate)
        {
            if (rate == null) return BadRequest();

            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!await _privateSchoolRepository.PrivateSchoolExists(schoolNumber)) return NotFound();

            PrivateSchoolRate oldRateEntity = await _privateSchoolRepository.GetRatesForSchool(schoolNumber, id);

            if (oldRateEntity == null) return NotFound();

            _mapper.Map(rate, oldRateEntity);


            if (!await _privateSchoolRepository.Save())
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }

            //return NoContent();
            return StatusCode(200, "Update Success!.");
        }

        // DELETE api/<controller>/5
        [HttpDelete("{schoolNumber}/privateschoolrate/{id}")]
        public async Task<ActionResult> DeletePatientreview(int schoolNumber, int id)
        {
            if (!await _privateSchoolRepository.PrivateSchoolExists(schoolNumber)) return NotFound();

            PrivateSchoolRate rateEntityForDelete = await _privateSchoolRepository.GetRatesForSchool(schoolNumber, id);
            if (rateEntityForDelete == null) return NotFound();

            _privateSchoolRateRepository.DeleteRate(rateEntityForDelete);

            if (!await _privateSchoolRepository.Save())
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }

            //return NoContent();
            return StatusCode(200, "Delete Success!.");
        }


    }
}
