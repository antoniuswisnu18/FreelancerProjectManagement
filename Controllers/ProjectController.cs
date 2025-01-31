using AutoMapper;
using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using FreelancerProjectManagementAPI.DTOs;
using FreelancerProjectManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace FreelancerProjectManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProjectService _service;

        public ProjectController(IMapper mapper, IProjectService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var projects = await _service.GetAll();
            return Ok(projects);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var project = await _service.GetById(id);
            if (project == null) return NotFound();
            return Ok(project);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ProjectCreateDTO projectDTO)
        {
            if (projectDTO == null) return BadRequest();
            if (!ModelState.IsValid) return BadRequest();

            var project =  _mapper.Map<Project>(projectDTO);
            await _service.Add(project);
            return CreatedAtAction(nameof(GetById), new { id = project.ProjectId }, project);
        }

        [HttpPut("id")]
        public async Task<IActionResult> Update(int id, [FromBody] ProjectUpdateDTO projectDTO)
        {
            var project = await _service.GetById(id);
            if (projectDTO == null || !ModelState.IsValid) return BadRequest();
            if (project == null) return NotFound();

            _mapper.Map(projectDTO, project);
            await _service.Update(project);
            return NoContent();
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteById(int id)
        {
            var project = await _service.GetById(id);
            if (project == null) return NotFound();
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
