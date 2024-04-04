using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class TaxiPathTransition
{
    public uint InPath { get; set; }

    public uint OutPath { get; set; }

    public uint InNode { get; set; }

    public uint OutNode { get; set; }

    public string? Comment { get; set; }

    /// <summary>
    /// Minimum game client build to load this entry
    /// </summary>
    public ushort BuildMin { get; set; }
}
