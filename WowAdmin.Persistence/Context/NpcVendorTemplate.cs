using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Npc System
/// </summary>
public partial class NpcVendorTemplate
{
    public uint Entry { get; set; }

    public ushort Slot { get; set; }

    public uint Item { get; set; }

    public byte Maxcount { get; set; }

    public uint Incrtime { get; set; }

    public uint Itemflags { get; set; }

    public uint ConditionId { get; set; }
}
