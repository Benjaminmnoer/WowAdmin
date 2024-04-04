using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Trigger System
/// </summary>
public partial class GameGraveyardZone
{
    public uint Id { get; set; }

    public uint GhostZone { get; set; }

    public ushort Faction { get; set; }

    /// <summary>
    /// Minimum content patch to load this entry
    /// </summary>
    public byte PatchMin { get; set; }

    /// <summary>
    /// Maximum content patch to load this entry
    /// </summary>
    public byte PatchMax { get; set; }
}
