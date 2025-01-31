using System.ComponentModel.DataAnnotations;

namespace FreelancerProjectManagementAPI.DTOs
{
    public class ProjectCreateDTO 
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string? Description { get; set; }
        [Required]
        public DateOnly StartDate { get; set; }
        [Required]
        public DateOnly EndDate { get; set; }
        [Required]
        public decimal Budget { get; set; }
    }
}
