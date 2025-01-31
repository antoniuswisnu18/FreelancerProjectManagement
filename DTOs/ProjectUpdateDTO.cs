using System.ComponentModel.DataAnnotations;

namespace FreelancerProjectManagementAPI.DTOs
{
    public class ProjectUpdateDTO
    {
        public string? Name { get; set; } = null!;
        
        public string? Description { get; set; }
        
        public DateOnly? StartDate { get; set; }
        
        public DateOnly? EndDate { get; set; }
        
        public decimal? Budget { get; set; }
    }
}
