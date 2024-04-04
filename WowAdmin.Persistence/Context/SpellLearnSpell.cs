using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Item System
/// </summary>
public partial class SpellLearnSpell
{
    public ushort Entry { get; set; }

    public ushort SpellId { get; set; }

    public byte Active { get; set; }

    /// <summary>
    /// Minimum game client build to load this entry
    /// </summary>
    public ushort BuildMin { get; set; }

    /// <summary>
    /// Maximum game client build to load this entry
    /// </summary>
    public ushort BuildMax { get; set; }
}
