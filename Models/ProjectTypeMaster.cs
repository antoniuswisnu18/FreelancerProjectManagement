using System;
using System.Collections.Generic;

namespace FreelancerProjectManagementAPI.Models;

public partial class ProjectTypeMaster
{
    public int ProjectTypeId { get; set; }

    public string ProjectTypeName { get; set; } = null!;

    public string? Description { get; set; }
}
