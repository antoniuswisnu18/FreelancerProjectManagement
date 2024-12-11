using System;
using System.Collections.Generic;

namespace FreelancerProjectManagementAPI.Models;

public partial class AuditTrail
{
    public int AuditId { get; set; }

    public int UserId { get; set; }

    public string? ActionType { get; set; }

    public string EntityName { get; set; } = null!;

    public int? EntityId { get; set; }

    public DateTime Timestamp { get; set; }

    public string? Details { get; set; }

    public string? Ipaddress { get; set; }
}
