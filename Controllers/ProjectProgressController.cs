using AutoMapper;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using FreelancerProjectManagementAPI.DTOs;
using FreelancerProjectManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreelancerProjectManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectProgressController : ControllerBase
    {
        private readonly IProjectProgressService _service;
        private readonly IMapper _mapper;

        public ProjectProgressController(IProjectProgressService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var projectProgresses = await _service.GetAll();
            return Ok(projectProgresses);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var projectProgress = await _service.GetById(id);
            if (projectProgress == null) return NotFound();
            return Ok(projectProgress);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ProjectProgressCreateDTO projectProgressDTO)
        {
            if (projectProgressDTO == null || !ModelState.IsValid) return BadRequest();
            var projectProgress = _mapper.Map<ProjectProgress>(projectProgressDTO);
            await _service.Add(projectProgress);
            return CreatedAtAction(nameof(GetById), new { id = projectProgress.ProjectId }, projectProgress);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            var projectProgress = await _service.GetById(id);
            if (projectProgress == null) return NotFound();
            await _service.Delete(id);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAll()
        {
            await _service.DeleteAll();
            return NoContent();
        }

        [HttpPut("id")]
        public async Task<IActionResult> Update(int id, [FromBody] ProjectProgressUpdateDTO projectProgressUpdateDTO)
        {
            if (projectProgressUpdateDTO == null) return BadRequest();
            var projectProgress = await _service.GetById(id);
            if (projectProgress == null) return NotFound();

            _mapper.Map(projectProgressUpdateDTO, projectProgress);

            await _service.Update(projectProgress);
            return NoContent();
        }
    }
}
