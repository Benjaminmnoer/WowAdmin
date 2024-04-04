using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PoolCreature
{
    public uint Guid { get; set; }

    public uint PoolEntry { get; set; }

    public string Description { get; set; } = null!;

    /// <summary>
    /// FLAG_SPAWN_ENABLE_IF_WORLD_POP_OVER_BLIZZLIKE = 1
    /// </summary>
    public uint Flags { get; set; }

    /// <summary>
    /// Minimum content patch to load this entry
    /// </summary>
    public byte PatchMin { get; set; }

    /// <summary>
    /// Maximum content patch to load this entry
    /// </summary>
    public byte PatchMax { get; set; }
}
