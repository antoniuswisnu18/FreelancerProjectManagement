using System;
using System.Collections.Generic;

namespace FreelancerProjectManagementAPI.Models;

public partial class PaymentStatusMaster
{
    public int PaymentStatusId { get; set; }

    public string PaymentStatusName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<FreelancerProject> FreelancerProjects { get; set; } = new List<FreelancerProject>();
}
