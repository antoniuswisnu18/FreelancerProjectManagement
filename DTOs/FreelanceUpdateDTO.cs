using System.ComponentModel.DataAnnotations;

namespace FreelancerProjectManagementAPI.DTOs
{
    public class FreelanceUpdateDTO
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone{ get; set; }
        public string? Skills{ get; set; }
        public decimal? RatePerHour { get; set; }
        public string? AvailabilityStatus { get; set; }
    }
}
