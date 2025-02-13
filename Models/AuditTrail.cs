using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreelancerProjectManagementAPI.Models;

public partial class AuditTrail
{
    [Key]
    public int AuditId { get; set; }

    [ForeignKey("User")]

    public int UserId { get; set; }

    public string? ActionType { get; set; }

    public string EntityName { get; set; } = null!;

    public int? EntityId { get; set; }

    public DateTime Timestamp { get; set; }

    public string? Details { get; set; }

    public string? Ipaddress { get; set; }
}
