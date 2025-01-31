using System.ComponentModel.DataAnnotations;

namespace FreelancerProjectManagementAPI.DTOs
{
    public class ProjectProgressCreateDTO
    {
        [Required]

        public int ProjectId { get; set; }
        [Required]

        public string TaskName { get; set; } = null!;

        public string? Description { get; set; }
        [Required]

        public DateOnly StartDate { get; set; }
        
        public DateOnly? EndDate { get; set; }

        [Required]
        public int ProgressStatusId { get; set; }
    }
}
