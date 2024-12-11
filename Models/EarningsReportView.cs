using System;
using System.Collections.Generic;

namespace FreelancerProjectManagementAPI.Models;

public partial class EarningsReportView
{
    public int FreelanceId { get; set; }

    public string FreelancerName { get; set; } = null!;

    public int? ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public decimal? TotalHours { get; set; }

    public decimal? TotalEarnings { get; set; }

    public int? TotalProjects { get; set; }

    public string PaymentStatus { get; set; } = null!;
}
