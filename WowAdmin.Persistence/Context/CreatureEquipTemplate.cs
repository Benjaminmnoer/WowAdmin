using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Creature System (Equipment)
/// </summary>
public partial class CreatureEquipTemplate
{
    /// <summary>
    /// Unique entry
    /// </summary>
    public uint Entry { get; set; }

    public uint Probability { get; set; }

    public uint Item1 { get; set; }

    public uint Item2 { get; set; }

    public uint Item3 { get; set; }

    /// <summary>
    /// Minimum content patch to load this entry
    /// </summary>
    public byte PatchMin { get; set; }

    /// <summary>
    /// Maximum content patch to load this entry
    /// </summary>
    public byte PatchMax { get; set; }
}
