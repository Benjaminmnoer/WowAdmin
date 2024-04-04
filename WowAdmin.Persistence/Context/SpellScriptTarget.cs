using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Spell System
/// </summary>
public partial class SpellScriptTarget
{
    public ushort Entry { get; set; }

    public byte Type { get; set; }

    public uint TargetEntry { get; set; }

    public uint ConditionId { get; set; }

    public uint InverseEffectMask { get; set; }

    /// <summary>
    /// Minimum game client build to load this entry
    /// </summary>
    public ushort BuildMin { get; set; }

    /// <summary>
    /// Maximum game client build to load this entry
    /// </summary>
    public ushort BuildMax { get; set; }
}
