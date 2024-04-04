using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class Geoip
{
    public int? NetworkStartInteger { get; set; }

    public int? NetworkLastInteger { get; set; }

    public string? GeonameId { get; set; }

    public string? RegisteredCountryGeonameId { get; set; }

    public string? RepresentedCountryGeonameId { get; set; }

    public int? IsAnonymousProxy { get; set; }

    public int? IsSatelliteProvider { get; set; }

    public string? PostalCode { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public int? AccuracyRadius { get; set; }
}
