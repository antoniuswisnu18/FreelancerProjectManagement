using System;
using System.Collections.Generic;

namespace FreelancerProjectManagementAPI.Models;

public partial class ProgressStatusMaster
{
    public int ProgressStatusId { get; set; }

    public string ProgressStatusName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<ProjectProgress> ProjectProgresses { get; set; } = new List<ProjectProgress>();
}
