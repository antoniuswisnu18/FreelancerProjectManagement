using System;
using System.Collections.Generic;

namespace FreelancerProjectManagementAPI.Models;

public partial class ProjectStatusView
{
    public int ProjectId { get; set; }

    public string ProjectName { get; set; } = null!;

    public int? TotalTasks { get; set; }

    public int? CompletedTasks { get; set; }

    public int? InProgressTasks { get; set; }

    public int? PendingTasks { get; set; }

    public int? DelayedTasks { get; set; }

    public string ProjectStatus { get; set; } = null!;

    public double? CompletionPercentage { get; set; }
}
