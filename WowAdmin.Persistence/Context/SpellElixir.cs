using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Spell System
/// </summary>
public partial class SpellElixir
{
    /// <summary>
    /// SpellId of potion
    /// </summary>
    public ushort Entry { get; set; }

    /// <summary>
    /// Mask 0x1 battle 0x2 guardian 0x3 flask 0x7 unstable flasks 0xB shattrath flasks
    /// </summary>
    public byte Mask { get; set; }

    /// <summary>
    /// Minimum game client build to load this entry
    /// </summary>
    public ushort BuildMin { get; set; }

    /// <summary>
    /// Maximum game client build to load this entry
    /// </summary>
    public ushort BuildMax { get; set; }
}
