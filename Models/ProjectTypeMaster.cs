using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreelancerProjectManagementAPI.Models;

public partial class ProjectTypeMaster
{
    [Key]
    public int ProjectTypeId { get; set; }

    public string ProjectTypeName { get; set; } = null!;

    public string? Description { get; set; }
}
