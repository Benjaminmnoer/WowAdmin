using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class GameEventCreatureDatum
{
    public uint Guid { get; set; }

    /// <summary>
    /// Content patch in which this exact version of the entry was added
    /// </summary>
    public byte Patch { get; set; }

    public uint EntryId { get; set; }

    public uint DisplayId { get; set; }

    public uint EquipmentId { get; set; }

    public ushort SpellStart { get; set; }

    public ushort SpellEnd { get; set; }

    public ushort Event { get; set; }
}
