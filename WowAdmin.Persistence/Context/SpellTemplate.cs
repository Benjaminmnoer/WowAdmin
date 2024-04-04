using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class SpellTemplate
{
    public ushort Entry { get; set; }

    /// <summary>
    /// Game client build for which to load this entry
    /// </summary>
    public ushort Build { get; set; }

    /// <summary>
    /// Resistances.dbc
    /// </summary>
    public uint School { get; set; }

    /// <summary>
    /// SpellCategory.dbc
    /// </summary>
    public uint Category { get; set; }

    public uint CastUi { get; set; }

    /// <summary>
    /// SpellDispelType.dbc
    /// </summary>
    public uint Dispel { get; set; }

    /// <summary>
    /// SpellMechanic.dbc
    /// </summary>
    public uint Mechanic { get; set; }

    public uint Attributes { get; set; }

    public uint AttributesEx { get; set; }

    public uint AttributesEx2 { get; set; }

    public uint AttributesEx3 { get; set; }

    public uint AttributesEx4 { get; set; }

    /// <summary>
    /// SpellShapeshiftForm.dbc
    /// </summary>
    public uint Stances { get; set; }

    /// <summary>
    /// SpellShapeshiftForm.dbc
    /// </summary>
    public uint StancesNot { get; set; }

    public uint Targets { get; set; }

    /// <summary>
    /// CreatureType.dbc
    /// </summary>
    public uint TargetCreatureType { get; set; }

    /// <summary>
    /// SpellFocusObject.dbc
    /// </summary>
    public uint RequiresSpellFocus { get; set; }

    public uint CasterAuraState { get; set; }

    public uint TargetAuraState { get; set; }

    /// <summary>
    /// SpellCastTimes.dbc
    /// </summary>
    public uint CastingTimeIndex { get; set; }

    public uint RecoveryTime { get; set; }

    public uint CategoryRecoveryTime { get; set; }

    public uint InterruptFlags { get; set; }

    public uint AuraInterruptFlags { get; set; }

    public uint ChannelInterruptFlags { get; set; }

    public uint ProcFlags { get; set; }

    public uint ProcChance { get; set; }

    public uint ProcCharges { get; set; }

    public uint MaxLevel { get; set; }

    public uint BaseLevel { get; set; }

    public uint SpellLevel { get; set; }

    /// <summary>
    /// SpellDuration.dbc
    /// </summary>
    public uint DurationIndex { get; set; }

    public uint PowerType { get; set; }

    public uint ManaCost { get; set; }

    public uint ManCostPerLevel { get; set; }

    public uint ManaPerSecond { get; set; }

    public uint ManaPerSecondPerLevel { get; set; }

    /// <summary>
    /// SpellRange.dbc
    /// </summary>
    public uint RangeIndex { get; set; }

    public float Speed { get; set; }

    public uint ModelNextSpell { get; set; }

    public uint StackAmount { get; set; }

    public uint Totem1 { get; set; }

    public uint Totem2 { get; set; }

    public int Reagent1 { get; set; }

    public int Reagent2 { get; set; }

    public int Reagent3 { get; set; }

    public int Reagent4 { get; set; }

    public int Reagent5 { get; set; }

    public int Reagent6 { get; set; }

    public int Reagent7 { get; set; }

    public int Reagent8 { get; set; }

    public uint ReagentCount1 { get; set; }

    public uint ReagentCount2 { get; set; }

    public uint ReagentCount3 { get; set; }

    public uint ReagentCount4 { get; set; }

    public uint ReagentCount5 { get; set; }

    public uint ReagentCount6 { get; set; }

    public uint ReagentCount7 { get; set; }

    public uint ReagentCount8 { get; set; }

    /// <summary>
    /// ItemClass.dbc
    /// </summary>
    public int EquippedItemClass { get; set; }

    /// <summary>
    /// ItemSubClass.dbc
    /// </summary>
    public int EquippedItemSubClassMask { get; set; }

    public int EquippedItemInventoryTypeMask { get; set; }

    public uint Effect1 { get; set; }

    public uint Effect2 { get; set; }

    public uint Effect3 { get; set; }

    public int EffectDieSides1 { get; set; }

    public int EffectDieSides2 { get; set; }

    public int EffectDieSides3 { get; set; }

    public uint EffectBaseDice1 { get; set; }

    public uint EffectBaseDice2 { get; set; }

    public uint EffectBaseDice3 { get; set; }

    public float EffectDicePerLevel1 { get; set; }

    public float EffectDicePerLevel2 { get; set; }

    public float EffectDicePerLevel3 { get; set; }

    public float EffectRealPointsPerLevel1 { get; set; }

    public float EffectRealPointsPerLevel2 { get; set; }

    public float EffectRealPointsPerLevel3 { get; set; }

    public int EffectBasePoints1 { get; set; }

    public int EffectBasePoints2 { get; set; }

    public int EffectBasePoints3 { get; set; }

    public float EffectBonusCoefficient1 { get; set; }

    public float EffectBonusCoefficient2 { get; set; }

    public float EffectBonusCoefficient3 { get; set; }

    public uint EffectMechanic1 { get; set; }

    public uint EffectMechanic2 { get; set; }

    public uint EffectMechanic3 { get; set; }

    public uint EffectImplicitTargetA1 { get; set; }

    public uint EffectImplicitTargetA2 { get; set; }

    public uint EffectImplicitTargetA3 { get; set; }

    public uint EffectImplicitTargetB1 { get; set; }

    public uint EffectImplicitTargetB2 { get; set; }

    public uint EffectImplicitTargetB3 { get; set; }

    /// <summary>
    /// SpellRadius.dbc
    /// </summary>
    public uint EffectRadiusIndex1 { get; set; }

    /// <summary>
    /// SpellRadius.dbc
    /// </summary>
    public uint EffectRadiusIndex2 { get; set; }

    /// <summary>
    /// SpellRadius.dbc
    /// </summary>
    public uint EffectRadiusIndex3 { get; set; }

    public uint EffectApplyAuraName1 { get; set; }

    public uint EffectApplyAuraName2 { get; set; }

    public uint EffectApplyAuraName3 { get; set; }

    public uint EffectAmplitude1 { get; set; }

    public uint EffectAmplitude2 { get; set; }

    public uint EffectAmplitude3 { get; set; }

    public float EffectMultipleValue1 { get; set; }

    public float EffectMultipleValue2 { get; set; }

    public float EffectMultipleValue3 { get; set; }

    public uint EffectChainTarget1 { get; set; }

    public uint EffectChainTarget2 { get; set; }

    public uint EffectChainTarget3 { get; set; }

    public uint EffectItemType1 { get; set; }

    public uint EffectItemType2 { get; set; }

    public uint EffectItemType3 { get; set; }

    public int EffectMiscValue1 { get; set; }

    public int EffectMiscValue2 { get; set; }

    public int EffectMiscValue3 { get; set; }

    public uint EffectTriggerSpell1 { get; set; }

    public uint EffectTriggerSpell2 { get; set; }

    public uint EffectTriggerSpell3 { get; set; }

    public float EffectPointsPerComboPoint1 { get; set; }

    public float EffectPointsPerComboPoint2 { get; set; }

    public float EffectPointsPerComboPoint3 { get; set; }

    /// <summary>
    /// SpellVisual.dbc
    /// </summary>
    public uint SpellVisual1 { get; set; }

    /// <summary>
    /// SpellVisual.dbc
    /// </summary>
    public uint SpellVisual2 { get; set; }

    /// <summary>
    /// SpellIcon.dbc
    /// </summary>
    public uint SpellIconId { get; set; }

    /// <summary>
    /// SpellIcon.dbc
    /// </summary>
    public uint ActiveIconId { get; set; }

    public uint SpellPriority { get; set; }

    public string Name { get; set; } = null!;

    public uint NameFlags { get; set; }

    public string NameSubtext { get; set; } = null!;

    public uint NameSubtextFlags { get; set; }

    public string Description { get; set; } = null!;

    public uint DescriptionFlags { get; set; }

    public string AuraDescription { get; set; } = null!;

    public uint AuraDescriptionFlags { get; set; }

    public uint ManaCostPercentage { get; set; }

    public uint StartRecoveryCategory { get; set; }

    public uint StartRecoveryTime { get; set; }

    /// <summary>
    /// Custom Field
    /// </summary>
    public uint MinTargetLevel { get; set; }

    public uint MaxTargetLevel { get; set; }

    /// <summary>
    /// ChrClasses.dbc
    /// </summary>
    public uint SpellFamilyName { get; set; }

    public ulong SpellFamilyFlags { get; set; }

    public uint MaxAffectedTargets { get; set; }

    public uint DmgClass { get; set; }

    public uint PreventionType { get; set; }

    public int StanceBarOrder { get; set; }

    public float DmgMultiplier1 { get; set; }

    public float DmgMultiplier2 { get; set; }

    public float DmgMultiplier3 { get; set; }

    public uint MinFactionId { get; set; }

    public uint MinReputation { get; set; }

    public uint RequiredAuraVision { get; set; }

    /// <summary>
    /// Custom Field
    /// </summary>
    public uint CustomFlags { get; set; }
}
