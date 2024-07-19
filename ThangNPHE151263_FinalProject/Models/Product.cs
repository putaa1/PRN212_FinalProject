using System;
using System.Collections.Generic;

namespace ThangNPHE151263_FinalProject.Models;

public partial class Product
{
    public long Id { get; set; }

    public long? IdGroupProduct { get; set; }

    public string? Name { get; set; }

    public string? Unit { get; set; }

    public double? UnitPrice { get; set; }

    public string? Description { get; set; }

    public string? Img { get; set; }

    public virtual ICollection<BillDetail> BillDetails { get; set; } = new List<BillDetail>();

    public virtual GroupProduct? IdGroupProductNavigation { get; set; }
}
