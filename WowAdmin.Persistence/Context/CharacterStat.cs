using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class CharacterStat
{
    /// <summary>
    /// Global Unique Identifier, Low part
    /// </summary>
    public uint Guid { get; set; }

    public uint MaxHealth { get; set; }

    public uint MaxPower1 { get; set; }

    public uint MaxPower2 { get; set; }

    public uint MaxPower3 { get; set; }

    public uint MaxPower4 { get; set; }

    public uint MaxPower5 { get; set; }

    public uint MaxPower6 { get; set; }

    public uint MaxPower7 { get; set; }

    public float Strength { get; set; }

    public float Agility { get; set; }

    public float Stamina { get; set; }

    public float Intellect { get; set; }

    public float Spirit { get; set; }

    public int Armor { get; set; }

    public int HolyRes { get; set; }

    public int FireRes { get; set; }

    public int NatureRes { get; set; }

    public int FrostRes { get; set; }

    public int ShadowRes { get; set; }

    public int ArcaneRes { get; set; }

    public float BlockChance { get; set; }

    public float DodgeChance { get; set; }

    public float ParryChance { get; set; }

    public float CritChance { get; set; }

    public float RangedCritChance { get; set; }

    public float SpellCritChance { get; set; }

    public uint AttackPower { get; set; }

    public uint RangedAttackPower { get; set; }

    public uint SpellDamage { get; set; }

    public uint SpellHealing { get; set; }
}
