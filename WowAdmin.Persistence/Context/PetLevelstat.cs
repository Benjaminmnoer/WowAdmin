using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Stores pet levels stats.
/// </summary>
public partial class PetLevelstat
{
    public uint Entry { get; set; }

    public byte Level { get; set; }

    public ushort Health { get; set; }

    public ushort Mana { get; set; }

    public uint Armor { get; set; }

    public float DmgMin { get; set; }

    public float DmgMax { get; set; }

    public ushort Strength { get; set; }

    public ushort Agility { get; set; }

    public ushort Stamina { get; set; }

    public ushort Intellect { get; set; }

    public ushort Spirit { get; set; }
}
