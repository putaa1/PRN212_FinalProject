using System;
using System.Collections.Generic;

namespace ThangNPHE151263_FinalProject.Models;

public partial class Login
{
    public long Id { get; set; }

    public long? IdEmployee { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public bool? IsUse { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual Employee? IdEmployeeNavigation { get; set; }

    public virtual ICollection<LoginRole> LoginRoles { get; set; } = new List<LoginRole>();
}
