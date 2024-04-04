using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class SpellMod
{
    public ushort Id { get; set; }

    public int? ProcChance { get; set; }

    public int? ProcFlags { get; set; }

    public int? ProcCharges { get; set; }

    public int? DurationIndex { get; set; }

    public int? Category { get; set; }

    public int? CastingTimeIndex { get; set; }

    public int? StackAmount { get; set; }

    public int? SpellIconId { get; set; }

    public int? ActiveIconId { get; set; }

    public int? ManaCost { get; set; }

    public int? Attributes { get; set; }

    public int? AttributesEx { get; set; }

    public int? AttributesEx2 { get; set; }

    public int? AttributesEx3 { get; set; }

    public int? AttributesEx4 { get; set; }

    public int? Custom { get; set; }

    public int? InterruptFlags { get; set; }

    public int? AuraInterruptFlags { get; set; }

    public int? ChannelInterruptFlags { get; set; }

    public int Dispel { get; set; }

    public int? Stances { get; set; }

    public int? StancesNot { get; set; }

    public int? SpellVisual { get; set; }

    public int? ManaCostPercentage { get; set; }

    public int? StartRecoveryCategory { get; set; }

    public int? StartRecoveryTime { get; set; }

    public int? MaxAffectedTargets { get; set; }

    public int? MaxTargetLevel { get; set; }

    public int? DmgClass { get; set; }

    public int? RangeIndex { get; set; }

    public int RecoveryTime { get; set; }

    public int CategoryRecoveryTime { get; set; }

    public int SpellFamilyName { get; set; }

    public ulong? SpellFamilyFlags { get; set; }

    public int? Mechanic { get; set; }

    public int? EquippedItemClass { get; set; }

    public string? Comment { get; set; }
}
