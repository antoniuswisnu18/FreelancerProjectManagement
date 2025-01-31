using FreelancerProjectManagementAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace FreelancerProjectManagementAPI.DTOs
{
    public class FreelancerCreateDTO
    {
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Skills { get; set; } = null!;
        [Required]
        public decimal RatePerHour { get; set; }
        [Required]
        public string AvailabilityStatus { get; set; } = null!;
    }
}
