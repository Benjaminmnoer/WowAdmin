using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class SpellEffectMod
{
    public ushort Id { get; set; }

    public uint EffectIndex { get; set; }

    public int Effect { get; set; }

    public int EffectDieSides { get; set; }

    public int EffectBaseDice { get; set; }

    public float EffectDicePerLevel { get; set; }

    public float EffectRealPointsPerLevel { get; set; }

    public int EffectBasePoints { get; set; }

    public int EffectAmplitude { get; set; }

    public float EffectPointsPerComboPoint { get; set; }

    public int EffectChainTarget { get; set; }

    public float EffectMultipleValue { get; set; }

    public int EffectMechanic { get; set; }

    public int EffectImplicitTargetA { get; set; }

    public int EffectImplicitTargetB { get; set; }

    public int EffectRadiusIndex { get; set; }

    public int EffectApplyAuraName { get; set; }

    public int EffectItemType { get; set; }

    public int EffectMiscValue { get; set; }

    public int EffectTriggerSpell { get; set; }

    public string? Comment { get; set; }
}
