using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Extra data for creature spawn.
/// </summary>
public partial class CreatureAddon
{
    public uint Guid { get; set; }

    /// <summary>
    /// Content patch in which this exact version of the entry was added
    /// </summary>
    public byte Patch { get; set; }

    public ushort DisplayId { get; set; }

    public short MountDisplayId { get; set; }

    public int EquipmentId { get; set; }

    public byte StandState { get; set; }

    public byte SheathState { get; set; }

    public ushort EmoteState { get; set; }

    public string? Auras { get; set; }
}
