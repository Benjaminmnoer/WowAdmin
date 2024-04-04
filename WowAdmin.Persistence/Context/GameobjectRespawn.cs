using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Grid Loading System
/// </summary>
public partial class GameobjectRespawn
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public long RespawnTime { get; set; }

    public uint Instance { get; set; }

    public uint? Map { get; set; }
}
