using System;
using System.Collections.Generic;

namespace ThangNPHE151263_FinalProject.Models;

public partial class Store
{
    public long Id { get; set; }

    public string? NameStore { get; set; }

    public string? AddressStore { get; set; }

    public string? PhoneStore { get; set; }

    public string? TaxCode { get; set; }
}
