using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Spell Additinal Data
/// </summary>
public partial class SpellChain
{
    public ushort SpellId { get; set; }

    public ushort PrevSpell { get; set; }

    public ushort FirstSpell { get; set; }

    public sbyte Rank { get; set; }

    public ushort ReqSpell { get; set; }

    /// <summary>
    /// Minimum game client build to load this entry
    /// </summary>
    public short BuildMin { get; set; }

    /// <summary>
    /// Maximum game client build to load this entry
    /// </summary>
    public short BuildMax { get; set; }
}
