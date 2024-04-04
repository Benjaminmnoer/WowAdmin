using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Pet System
/// </summary>
public partial class CharacterPet
{
    public uint Id { get; set; }

    public uint Entry { get; set; }

    public uint OwnerGuid { get; set; }

    public uint? DisplayId { get; set; }

    public uint CreatedBySpell { get; set; }

    public byte PetType { get; set; }

    public uint Level { get; set; }

    public uint Xp { get; set; }

    public byte ReactState { get; set; }

    public int LoyaltyPoints { get; set; }

    public uint Loyalty { get; set; }

    public int TrainingPoints { get; set; }

    public string? Name { get; set; }

    public byte Renamed { get; set; }

    public uint Slot { get; set; }

    public uint CurrentHealth { get; set; }

    public uint CurrentMana { get; set; }

    public uint CurrentHappiness { get; set; }

    public ulong SaveTime { get; set; }

    public uint ResetTalentsCost { get; set; }

    public ulong ResetTalentsTime { get; set; }

    public string? ActionBarData { get; set; }

    public string? TeachSpellData { get; set; }
}
