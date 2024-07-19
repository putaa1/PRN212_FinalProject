using System;
using System.Collections.Generic;

namespace ThangNPHE151263_FinalProject.Models;

public partial class Table
{
    public long Id { get; set; }

    public string? NameTb { get; set; }

    public string? Description { get; set; }

    public long? IdGroup { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual GroupTable? IdGroupNavigation { get; set; }
}
