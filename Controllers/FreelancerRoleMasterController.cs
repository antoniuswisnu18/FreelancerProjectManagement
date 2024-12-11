using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace FreelancerProjectManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelancerRoleMasterController : ControllerBase
    {
        private readonly IFreelancerRoleMasterService _service;
        public FreelancerRoleMasterController(IFreelancerRoleMasterService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRole()
        {
            var roles = await _service.GetAllRoleAsync();
            return Ok(roles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoleById(int id)
        {
            var role = await _service.GetRoleById(id);

            if (role == null)
            {
                return NotFound();
            }

            return Ok(role);
        }
    }
}
