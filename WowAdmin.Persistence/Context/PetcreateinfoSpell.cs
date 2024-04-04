using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Pet Create Spells
/// </summary>
public partial class PetcreateinfoSpell
{
    public uint Entry { get; set; }

    public ushort Spell1 { get; set; }

    public ushort Spell2 { get; set; }

    public ushort Spell3 { get; set; }

    public ushort Spell4 { get; set; }

    /// <summary>
    /// Minimum content patch to load this entry
    /// </summary>
    public byte PatchMin { get; set; }

    /// <summary>
    /// Maximum content patch to load this entry
    /// </summary>
    public byte PatchMax { get; set; }
}
