using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreelancerProjectManagementAPI.Models;

public partial class ProjectProgress
{
    [Key]
    public int ProgressId { get; set; }
    [ForeignKey("Project")]

    public int ProjectId { get; set; }

    public string TaskName { get; set; } = null!;

    public string? Description { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public int ProgressStatusId { get; set; }

    public virtual ProgressStatusMaster ProgressStatus { get; set; } = null!;

    public virtual Project Project { get; set; } = null!;
}
