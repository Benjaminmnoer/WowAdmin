using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PoolPool
{
    public uint PoolId { get; set; }

    public uint MotherPool { get; set; }

    public float Chance { get; set; }

    public string Description { get; set; } = null!;

    /// <summary>
    /// FLAG_SPAWN_ENABLE_IF_WORLD_POP_OVER_BLIZZLIKE = 1
    /// </summary>
    public uint Flags { get; set; }
}
