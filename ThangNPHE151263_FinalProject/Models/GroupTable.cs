using System;
using System.Collections.Generic;

namespace ThangNPHE151263_FinalProject.Models;

public partial class GroupTable
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
