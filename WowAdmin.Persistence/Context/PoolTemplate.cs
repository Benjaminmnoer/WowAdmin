using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PoolTemplate
{
    /// <summary>
    /// Pool entry
    /// </summary>
    public uint Entry { get; set; }

    /// <summary>
    /// Max number of objects (0) is no limit
    /// </summary>
    public uint MaxLimit { get; set; }

    public string Description { get; set; } = null!;

    public uint Flags { get; set; }

    public int Instance { get; set; }

    /// <summary>
    /// Minimum content patch to load this entry
    /// </summary>
    public byte PatchMin { get; set; }

    /// <summary>
    /// Maximum content patch to load this entry
    /// </summary>
    public byte PatchMax { get; set; }
}
