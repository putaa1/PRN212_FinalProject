using System;
using System.Collections.Generic;

namespace ThangNPHE151263_FinalProject.Models;

public partial class Bill
{
    public long Id { get; set; }

    public long? IdTable { get; set; }

    public DateTime? BillDate { get; set; }

    public double? TotalMoney { get; set; }

    public bool? Status { get; set; }

    public string? Description { get; set; }

    public long? IdUser { get; set; }

    public long? IdCustomer { get; set; }

    public virtual ICollection<BillDetail> BillDetails { get; set; } = new List<BillDetail>();

    public virtual Customer? IdCustomerNavigation { get; set; }

    public virtual Table? IdTableNavigation { get; set; }

    public virtual Login? IdUserNavigation { get; set; }
}
