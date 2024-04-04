using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Item System
/// </summary>
public partial class ItemText
{
    public uint Id { get; set; }

    public string? Text { get; set; }
}
