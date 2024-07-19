using System;
using System.Collections.Generic;

namespace ThangNPHE151263_FinalProject.Models;

public partial class Customer
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Description { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
