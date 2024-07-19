using System;
using System.Collections.Generic;

namespace ThangNPHE151263_FinalProject.Models;

public partial class BillDetail
{
    public long Id { get; set; }

    public double? UnitPrice { get; set; }

    public int? Quantity { get; set; }

    public long? IdBill { get; set; }

    public long? IdProduct { get; set; }

    public double? IntoMoney { get; set; }

    public string? Description { get; set; }

    public virtual Bill? IdBillNavigation { get; set; }

    public virtual Product? IdProductNavigation { get; set; }
}
