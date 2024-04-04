using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Creature System (display id related info)
/// </summary>
public partial class CreatureDisplayInfoAddon
{
    public uint DisplayId { get; set; }

    /// <summary>
    /// Game client build in which this exact version was added
    /// </summary>
    public ushort Build { get; set; }

    public float BoundingRadius { get; set; }

    public float CombatReach { get; set; }

    public float SpeedWalk { get; set; }

    public float SpeedRun { get; set; }

    public byte Gender { get; set; }

    public uint DisplayIdOtherGender { get; set; }
}
