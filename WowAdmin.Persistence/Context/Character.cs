using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Player System
/// </summary>
public partial class Character
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Account Identifier
    /// </summary>
    public uint Account { get; set; }

    public string Name { get; set; } = null!;

    public byte Race { get; set; }

    public byte Class { get; set; }

    public byte Gender { get; set; }

    public byte Skin { get; set; }

    public byte Face { get; set; }

    public byte HairStyle { get; set; }

    public byte HairColor { get; set; }

    public byte FacialHair { get; set; }

    public byte Level { get; set; }

    public uint Xp { get; set; }

    public uint Money { get; set; }

    public uint PlayerFlags { get; set; }

    public uint Zone { get; set; }

    /// <summary>
    /// Map Identifier
    /// </summary>
    public uint Map { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public float PositionZ { get; set; }

    public float Orientation { get; set; }

    public ulong TransportGuid { get; set; }

    public float TransportX { get; set; }

    public float TransportY { get; set; }

    public float TransportZ { get; set; }

    public float TransportO { get; set; }

    /// <summary>
    /// discovered flight points
    /// </summary>
    public string? KnownTaxiMask { get; set; }

    /// <summary>
    /// flight destination
    /// </summary>
    public string? CurrentTaxiPath { get; set; }

    public byte Online { get; set; }

    public uint PlayedTimeTotal { get; set; }

    public uint PlayedTimeLevel { get; set; }

    public ulong CreateTime { get; set; }

    public ulong LogoutTime { get; set; }

    public byte IsLogoutResting { get; set; }

    public float RestBonus { get; set; }

    public uint ResetTalentsMultiplier { get; set; }

    public ulong ResetTalentsTime { get; set; }

    public ulong DeathExpireTime { get; set; }

    public byte StableSlots { get; set; }

    public byte BankBagSlots { get; set; }

    public uint AtLoginFlags { get; set; }

    public uint ExtraFlags { get; set; }

    public float HonorRankPoints { get; set; }

    public uint HonorHighestRank { get; set; }

    public uint HonorStanding { get; set; }

    public uint HonorLastWeekHk { get; set; }

    public float HonorLastWeekCp { get; set; }

    public int HonorStoredHk { get; set; }

    public int HonorStoredDk { get; set; }

    public int WatchedFaction { get; set; }

    public ushort Drunk { get; set; }

    public uint Health { get; set; }

    public uint Power1 { get; set; }

    public uint Power2 { get; set; }

    public uint Power3 { get; set; }

    public uint Power4 { get; set; }

    public uint Power5 { get; set; }

    public string? ExploredZones { get; set; }

    public string? EquipmentCache { get; set; }

    public uint AmmoId { get; set; }

    public byte ActionBars { get; set; }

    public uint? DeletedAccount { get; set; }

    public string? DeletedName { get; set; }

    public long? DeletedTime { get; set; }

    public int? WorldPhaseMask { get; set; }
}
