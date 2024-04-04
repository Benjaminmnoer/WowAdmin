using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class SpellAffect
{
    public ushort Entry { get; set; }

    public byte EffectId { get; set; }

    public ulong SpellFamilyMask { get; set; }

    /// <summary>
    /// Minimum game client build to load this entry
    /// </summary>
    public ushort BuildMin { get; set; }

    /// <summary>
    /// Maximum game client build to load this entry
    /// </summary>
    public ushort BuildMax { get; set; }
}
