using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Item System
/// </summary>
public partial class ItemLoot
{
    public uint Guid { get; set; }

    public uint OwnerGuid { get; set; }

    public uint ItemId { get; set; }

    public uint Amount { get; set; }

    public int Property { get; set; }
}
