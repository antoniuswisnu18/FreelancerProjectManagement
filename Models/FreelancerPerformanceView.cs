using System;
using System.Collections.Generic;

namespace FreelancerProjectManagementAPI.Models;

public partial class FreelancerPerformanceView
{
    public int FreelanceId { get; set; }

    public string FreelancerName { get; set; } = null!;

    public int? TotalProjects { get; set; }

    public int? TotalTasks { get; set; }

    public int? CompletedTasks { get; set; }

    public double? CompletionRate { get; set; }

    public int? AvgCompletionTime { get; set; }

    public DateTime? LastUpdatedProject { get; set; }

    public DateTime? LastUpdatedTask { get; set; }
}
