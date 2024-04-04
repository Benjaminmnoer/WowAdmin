using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Aura removal on map entry
/// </summary>
public partial class InstanceBuffRemoval
{
    /// <summary>
    /// MapId to remove aura from
    /// </summary>
    public uint MapId { get; set; }

    /// <summary>
    /// aura id to remove on entering MapId
    /// </summary>
    public ushort SpellId { get; set; }

    /// <summary>
    /// aura removal enabled or not
    /// </summary>
    public bool Enabled { get; set; }

    /// <summary>
    /// flags, see AuraRemovalMgr.h
    /// </summary>
    public int Flags { get; set; }

    /// <summary>
    /// description, what is removed
    /// </summary>
    public string Comment { get; set; } = null!;
}
