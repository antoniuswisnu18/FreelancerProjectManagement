using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreelancerProjectManagementAPI.Models;

public partial class FreelancerProject
{
    [Key]
    public int AssignmentId { get; set; }

    [ForeignKey("Freelancer")]

    public int FreelancerId { get; set; }
    [ForeignKey("Project")]

    public int ProjectId { get; set; }

    public decimal HourlyRate { get; set; }

    public decimal? TotalHours { get; set; }

    public DateTime AssignedAt { get; set; }

    public int PaymentStatusId { get; set; }

    public int? FreelancerRoleId { get; set; }

    public virtual Freelancer Freelancer { get; set; } = null!;

    public virtual FreelancerRoleMaster? FreelancerRole { get; set; }

    public virtual PaymentStatusMaster PaymentStatus { get; set; } = null!;

    public virtual Project Project { get; set; } = null!;
}
