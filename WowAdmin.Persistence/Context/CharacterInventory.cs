using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterInventory
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public uint Bag { get; set; }

    public byte Slot { get; set; }

    /// <summary>
    /// Item Global Unique Identifier
    /// </summary>
    public uint ItemGuid { get; set; }

    /// <summary>
    /// Item Identifier
    /// </summary>
    public uint ItemId { get; set; }
}
