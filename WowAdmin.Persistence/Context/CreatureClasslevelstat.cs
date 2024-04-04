using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Base stats for creatures per class and level.
/// </summary>
public partial class CreatureClasslevelstat
{
    public byte Class { get; set; }

    public byte Level { get; set; }

    public float MeleeDamage { get; set; }

    public float RangedDamage { get; set; }

    public int AttackPower { get; set; }

    public int RangedAttackPower { get; set; }

    /// <summary>
    /// value used with multipliers to get total health
    /// </summary>
    public int Health { get; set; }

    public int BaseHealth { get; set; }

    /// <summary>
    /// value used with multipliers to get total mana
    /// </summary>
    public int Mana { get; set; }

    public int BaseMana { get; set; }

    public int Strength { get; set; }

    public int Agility { get; set; }

    public int Stamina { get; set; }

    public int Intellect { get; set; }

    public int Spirit { get; set; }

    public int Armor { get; set; }
}
