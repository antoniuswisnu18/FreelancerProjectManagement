using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreelancerProjectManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgressStatusMasterController : ControllerBase
    {
        private readonly IProgressStatusMasterService _service;

        public ProgressStatusMasterController(IProgressStatusMasterService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStatus()
        {
            var status = await _service.GetAll();
            return Ok(status);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStatusById(int id)
        {
            var status = await _service.GetById(id);
            if (status == null)
            {
                return NotFound();
            }

            return Ok(status);
        }
    }
}
