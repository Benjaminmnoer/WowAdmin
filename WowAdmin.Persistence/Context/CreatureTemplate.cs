using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Creature System
/// </summary>
public partial class CreatureTemplate
{
    public uint Entry { get; set; }

    /// <summary>
    /// Content patch in which this exact version of the entry was added
    /// </summary>
    public byte Patch { get; set; }

    public string Name { get; set; } = null!;

    public string? Subname { get; set; }

    public byte LevelMin { get; set; }

    public byte LevelMax { get; set; }

    public ushort Faction { get; set; }

    public uint NpcFlags { get; set; }

    public uint GossipMenuId { get; set; }

    public uint DisplayId1 { get; set; }

    public uint DisplayId2 { get; set; }

    public uint DisplayId3 { get; set; }

    public uint DisplayId4 { get; set; }

    public float DisplayScale1 { get; set; }

    public float DisplayScale2 { get; set; }

    public float DisplayScale3 { get; set; }

    public float DisplayScale4 { get; set; }

    public ushort DisplayProbability1 { get; set; }

    public ushort DisplayProbability2 { get; set; }

    public ushort DisplayProbability3 { get; set; }

    public ushort DisplayProbability4 { get; set; }

    public ushort DisplayTotalProbability { get; set; }

    public ushort MountDisplayId { get; set; }

    /// <summary>
    /// Result of 2.5/2.5, most common value
    /// </summary>
    public float SpeedWalk { get; set; }

    /// <summary>
    /// Result of 8.0/7.0, most common value
    /// </summary>
    public float SpeedRun { get; set; }

    public float DetectionRange { get; set; }

    public float CallForHelpRange { get; set; }

    public float LeashRange { get; set; }

    public byte Rank { get; set; }

    public float XpMultiplier { get; set; }

    public float HealthMultiplier { get; set; }

    public float ManaMultiplier { get; set; }

    public float ArmorMultiplier { get; set; }

    public float DamageMultiplier { get; set; }

    public float DamageVariance { get; set; }

    public byte DamageSchool { get; set; }

    public uint BaseAttackTime { get; set; }

    public uint RangedAttackTime { get; set; }

    public short HolyRes { get; set; }

    public short FireRes { get; set; }

    public short NatureRes { get; set; }

    public short FrostRes { get; set; }

    public short ShadowRes { get; set; }

    public short ArcaneRes { get; set; }

    public byte UnitClass { get; set; }

    public uint UnitFlags { get; set; }

    public byte PetFamily { get; set; }

    public byte TrainerType { get; set; }

    public ushort TrainerSpell { get; set; }

    public byte TrainerClass { get; set; }

    public byte TrainerRace { get; set; }

    public byte Type { get; set; }

    public uint TypeFlags { get; set; }

    public uint LootId { get; set; }

    public uint PickpocketLootId { get; set; }

    public uint SkinningLootId { get; set; }

    public uint GoldMin { get; set; }

    public uint GoldMax { get; set; }

    public ushort SpellId1 { get; set; }

    public ushort SpellId2 { get; set; }

    public ushort SpellId3 { get; set; }

    public ushort SpellId4 { get; set; }

    public uint SpellListId { get; set; }

    public uint PetSpellListId { get; set; }

    /// <summary>
    /// Spell with effect 46 that will be cast immediately upon spawning. Creature will remain unattackable until the cast finishes.
    /// </summary>
    public ushort SpawnSpellId { get; set; }

    public string? Auras { get; set; }

    public string AiName { get; set; } = null!;

    public byte MovementType { get; set; }

    public byte InhabitType { get; set; }

    public byte Civilian { get; set; }

    public byte RacialLeader { get; set; }

    public byte Regeneration { get; set; }

    public uint EquipmentId { get; set; }

    public uint TrainerId { get; set; }

    public uint VendorId { get; set; }

    public uint MechanicImmuneMask { get; set; }

    public uint SchoolImmuneMask { get; set; }

    public uint ImmunityFlags { get; set; }

    public uint FlagsExtra { get; set; }

    public string ScriptName { get; set; } = null!;
}
