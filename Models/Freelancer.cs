using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreelancerProjectManagementAPI.Models;

public partial class Freelancer
{
    [Key]
    public int FreelanceId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Skills { get; set; } = null!;

    public decimal RatePerHour { get; set; }

    public string AvailabilityStatus { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<FreelancerProject> FreelancerProjects { get; set; } = new List<FreelancerProject>();
}
