using AutoMapper;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using FreelancerProjectManagementAPI.CustomException;
using FreelancerProjectManagementAPI.DTOs;
using FreelancerProjectManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace FreelancerProjectManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelancerController : ControllerBase
    {
        private readonly IFreelancerService _service;
        private readonly IMapper _mapper;
        public FreelancerController(IFreelancerService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            var freelancer = await _service.GetAll();
            return Ok(freelancer);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var freelancer = await _service.GetById(id);
            if (freelancer == null) throw new NotFoundException($"Freelancer with id {id} not found.");
            return Ok(freelancer);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] FreelancerCreateDTO freelancerDTO)
        {
            if (freelancerDTO == null) return BadRequest();
            if (!ModelState.IsValid) return BadRequest();

            var freelancer = _mapper.Map<Freelancer>(freelancerDTO);
            await _service.Add(freelancer);
            return CreatedAtAction(nameof(GetById), new {id = freelancer.FreelanceId}, freelancer);
        }

        [HttpPut("id")]
        public async Task<IActionResult> Update(int id, [FromBody] FreelanceUpdateDTO freelancerDTO)
        {
            if (freelancerDTO == null || !ModelState.IsValid) return BadRequest();

            var freelancer = await _service.GetById(id);
            if (freelancer == null) return NotFound();

            _mapper.Map(freelancerDTO, freelancer);

            await _service.Update(freelancer);
            return NoContent();
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAll()
        {
            await _service.DeleteAll();
            return NoContent();
        }

    }

}
