using System;
using System.Collections.Generic;

namespace ThangNPHE151263_FinalProject.Models;

public partial class GroupProduct
{
    public long IdGr { get; set; }

    public string? NameGr { get; set; }

    public string? DescriptionGr { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
