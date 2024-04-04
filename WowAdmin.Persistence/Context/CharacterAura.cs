using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterAura
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Full Global Unique Identifier
    /// </summary>
    public ulong CasterGuid { get; set; }

    public uint ItemGuid { get; set; }

    public uint Spell { get; set; }

    public uint Stacks { get; set; }

    public uint Charges { get; set; }

    public float BasePoints0 { get; set; }

    public float BasePoints1 { get; set; }

    public float BasePoints2 { get; set; }

    public uint PeriodicTime0 { get; set; }

    public uint PeriodicTime1 { get; set; }

    public uint PeriodicTime2 { get; set; }

    public int MaxDuration { get; set; }

    public int Duration { get; set; }

    public byte EffectIndexMask { get; set; }
}
