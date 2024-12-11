using System;
using System.Collections.Generic;

namespace FreelancerProjectManagementAPI.Models;

public partial class FreelancerRoleMaster
{
    public int FreelancerRoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<FreelancerProject> FreelancerProjects { get; set; } = new List<FreelancerProject>();
}
