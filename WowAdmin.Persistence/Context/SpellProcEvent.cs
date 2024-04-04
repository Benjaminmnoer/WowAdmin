using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class SpellProcEvent
{
    public ushort Entry { get; set; }

    public byte SchoolMask { get; set; }

    public ushort SpellFamilyName { get; set; }

    public ulong SpellFamilyMask0 { get; set; }

    public ulong SpellFamilyMask1 { get; set; }

    public ulong SpellFamilyMask2 { get; set; }

    public uint ProcFlags { get; set; }

    public uint ProcEx { get; set; }

    public float PpmRate { get; set; }

    public float CustomChance { get; set; }

    public uint Cooldown { get; set; }

    /// <summary>
    /// Minimum game client build to load this entry
    /// </summary>
    public ushort BuildMin { get; set; }

    /// <summary>
    /// Maximum game client build to load this entry
    /// </summary>
    public ushort BuildMax { get; set; }
}
