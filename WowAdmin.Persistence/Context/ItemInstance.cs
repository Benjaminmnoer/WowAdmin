using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Item System
/// </summary>
public partial class ItemInstance
{
    public uint Guid { get; set; }

    public uint ItemId { get; set; }

    public uint OwnerGuid { get; set; }

    public uint CreatorGuid { get; set; }

    public uint GiftCreatorGuid { get; set; }

    public uint Count { get; set; }

    public int Duration { get; set; }

    public string? Charges { get; set; }

    public uint Flags { get; set; }

    public string Enchantments { get; set; } = null!;

    public short RandomPropertyId { get; set; }

    public ushort Durability { get; set; }

    public uint Text { get; set; }

    public sbyte? GeneratedLoot { get; set; }
}
