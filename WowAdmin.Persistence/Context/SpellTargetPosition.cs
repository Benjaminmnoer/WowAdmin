using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Spell System
/// </summary>
public partial class SpellTargetPosition
{
    /// <summary>
    /// Identifier
    /// </summary>
    public ushort Id { get; set; }

    public ushort TargetMap { get; set; }

    public float TargetPositionX { get; set; }

    public float TargetPositionY { get; set; }

    public float TargetPositionZ { get; set; }

    public float TargetOrientation { get; set; }

    /// <summary>
    /// Minimum game client build to load this entry
    /// </summary>
    public ushort BuildMin { get; set; }

    /// <summary>
    /// Maximum game client build to load this entry
    /// </summary>
    public ushort BuildMax { get; set; }
}
