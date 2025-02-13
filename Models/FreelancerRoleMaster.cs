using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreelancerProjectManagementAPI.Models;

public partial class FreelancerRoleMaster
{
    [Key]
    public int FreelancerRoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<FreelancerProject> FreelancerProjects { get; set; } = new List<FreelancerProject>();
}
