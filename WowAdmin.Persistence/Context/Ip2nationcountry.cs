using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class Ip2nationcountry
{
    public string Code { get; set; } = null!;

    public string IsoCode2 { get; set; } = null!;

    public string? IsoCode3 { get; set; }

    public string IsoCountry { get; set; } = null!;

    public string Country { get; set; } = null!;

    public float Lat { get; set; }

    public float Lon { get; set; }
}
