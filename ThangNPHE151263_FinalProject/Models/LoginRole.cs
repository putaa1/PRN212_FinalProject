using System;
using System.Collections.Generic;

namespace ThangNPHE151263_FinalProject.Models;

public partial class LoginRole
{
    public long Id { get; set; }

    public long IdLogin { get; set; }

    public int IdMenuItems { get; set; }

    public virtual Login IdLoginNavigation { get; set; } = null!;

    public virtual MenuItem IdMenuItemsNavigation { get; set; } = null!;
}
