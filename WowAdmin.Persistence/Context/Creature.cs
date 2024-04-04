using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Creature System
/// </summary>
public partial class Creature
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Creature Template Id
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// Creature Template Id
    /// </summary>
    public uint Id2 { get; set; }

    /// <summary>
    /// Creature Template Id
    /// </summary>
    public uint Id3 { get; set; }

    /// <summary>
    /// Creature Template Id
    /// </summary>
    public uint Id4 { get; set; }

    /// <summary>
    /// Creature Template Id
    /// </summary>
    public uint Id5 { get; set; }

    /// <summary>
    /// Map Identifier
    /// </summary>
    public ushort Map { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public float PositionZ { get; set; }

    public float Orientation { get; set; }

    public uint Spawntimesecsmin { get; set; }

    public uint Spawntimesecsmax { get; set; }

    public float WanderDistance { get; set; }

    public float HealthPercent { get; set; }

    public byte MovementType { get; set; }

    public uint SpawnFlags { get; set; }

    public float? VisibilityMod { get; set; }

    /// <summary>
    /// Minimum content patch to load this entry
    /// </summary>
    public byte PatchMin { get; set; }

    /// <summary>
    /// Maximum content patch to load this entry
    /// </summary>
    public byte PatchMax { get; set; }
}
