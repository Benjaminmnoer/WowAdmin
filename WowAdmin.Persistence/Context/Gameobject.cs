using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Gameobject System
/// </summary>
public partial class Gameobject
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Gameobject Identifier
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// Map Identifier
    /// </summary>
    public ushort Map { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public float PositionZ { get; set; }

    public float Orientation { get; set; }

    public float Rotation0 { get; set; }

    public float Rotation1 { get; set; }

    public float Rotation2 { get; set; }

    public float Rotation3 { get; set; }

    public int Spawntimesecsmin { get; set; }

    public int Spawntimesecsmax { get; set; }

    public byte Animprogress { get; set; }

    public byte State { get; set; }

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
