using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Spell System
/// </summary>
public partial class SpellGroup
{
    public uint GroupId { get; set; }

    public uint GroupSpellId { get; set; }

    public ushort SpellId { get; set; }

    /// <summary>
    /// Minimum game client build to load this entry
    /// </summary>
    public ushort BuildMin { get; set; }

    /// <summary>
    /// Maximum game client build to load this entry
    /// </summary>
    public ushort BuildMax { get; set; }
}
