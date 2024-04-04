using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class LocalesFaction
{
    public uint Entry { get; set; }

    public string NameLoc1 { get; set; } = null!;

    public string NameLoc2 { get; set; } = null!;

    public string NameLoc3 { get; set; } = null!;

    public string NameLoc4 { get; set; } = null!;

    public string NameLoc5 { get; set; } = null!;

    public string NameLoc6 { get; set; } = null!;

    public string DescriptionLoc1 { get; set; } = null!;

    public string DescriptionLoc2 { get; set; } = null!;

    public string DescriptionLoc3 { get; set; } = null!;

    public string DescriptionLoc4 { get; set; } = null!;

    public string DescriptionLoc5 { get; set; } = null!;

    public string DescriptionLoc6 { get; set; } = null!;
}
