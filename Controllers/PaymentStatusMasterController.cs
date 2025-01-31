using FreelancerProjectManagementAPI.BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreelancerProjectManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentStatusMasterController : ControllerBase
    {
        private readonly IPaymentStatusMasterService _service;

        public PaymentStatusMasterController(IPaymentStatusMasterService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPaymentStatus()
        {
            var payment_status = await _service.GetAllStatus();
            return Ok(payment_status);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStatusById(int id)
        {
            var payment_status = await _service.GetStatusById(id);
            if (payment_status == null)
            {
                return NotFound();
            }

            return Ok(payment_status);
        }
    }
}
