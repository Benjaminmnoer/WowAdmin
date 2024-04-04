using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Trigger System
/// </summary>
public partial class AreatriggerTeleport
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// Content patch in which this exact version of the entry was added
    /// </summary>
    public byte Patch { get; set; }

    public string Name { get; set; } = null!;

    public string Message { get; set; } = null!;

    public byte RequiredLevel { get; set; }

    public uint RequiredCondition { get; set; }

    public ushort TargetMap { get; set; }

    public float TargetPositionX { get; set; }

    public float TargetPositionY { get; set; }

    public float TargetPositionZ { get; set; }

    public float TargetOrientation { get; set; }
}
