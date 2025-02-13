using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreelancerProjectManagementAPI.Models;

public partial class User
{
    [Key]
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Role { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
