namespace FreelancerProjectManagementAPI.DTOs
{
    public class ProjectProgressUpdateDTO
    {
        public string? TaskName { get; set; } = null!;

        public string? Description { get; set; }

        public DateOnly? StartDate { get; set; }

        public DateOnly? EndDate { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string? UpdatedBy { get; set; }

        public int? ProgressStatusId { get; set; }
    }
}
