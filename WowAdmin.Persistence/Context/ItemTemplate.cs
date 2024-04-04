using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Item System
/// </summary>
public partial class ItemTemplate
{
    public uint Entry { get; set; }

    /// <summary>
    /// Content patch in which this exact version of the entry was added
    /// </summary>
    public byte Patch { get; set; }

    public byte Class { get; set; }

    public byte Subclass { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint DisplayId { get; set; }

    public byte Quality { get; set; }

    public uint Flags { get; set; }

    public byte BuyCount { get; set; }

    public uint BuyPrice { get; set; }

    public uint SellPrice { get; set; }

    public byte InventoryType { get; set; }

    public int AllowableClass { get; set; }

    public int AllowableRace { get; set; }

    public byte ItemLevel { get; set; }

    public byte RequiredLevel { get; set; }

    public ushort RequiredSkill { get; set; }

    public ushort RequiredSkillRank { get; set; }

    public ushort RequiredSpell { get; set; }

    public uint RequiredHonorRank { get; set; }

    public uint RequiredCityRank { get; set; }

    public ushort RequiredReputationFaction { get; set; }

    public ushort RequiredReputationRank { get; set; }

    public ushort MaxCount { get; set; }

    public ushort Stackable { get; set; }

    public byte ContainerSlots { get; set; }

    public byte StatType1 { get; set; }

    public short StatValue1 { get; set; }

    public byte StatType2 { get; set; }

    public short StatValue2 { get; set; }

    public byte StatType3 { get; set; }

    public short StatValue3 { get; set; }

    public byte StatType4 { get; set; }

    public short StatValue4 { get; set; }

    public byte StatType5 { get; set; }

    public short StatValue5 { get; set; }

    public byte StatType6 { get; set; }

    public short StatValue6 { get; set; }

    public byte StatType7 { get; set; }

    public short StatValue7 { get; set; }

    public byte StatType8 { get; set; }

    public short StatValue8 { get; set; }

    public byte StatType9 { get; set; }

    public short StatValue9 { get; set; }

    public byte StatType10 { get; set; }

    public short StatValue10 { get; set; }

    public ushort Delay { get; set; }

    public float RangeMod { get; set; }

    public byte AmmoType { get; set; }

    public float DmgMin1 { get; set; }

    public float DmgMax1 { get; set; }

    public byte DmgType1 { get; set; }

    public float DmgMin2 { get; set; }

    public float DmgMax2 { get; set; }

    public byte DmgType2 { get; set; }

    public float DmgMin3 { get; set; }

    public float DmgMax3 { get; set; }

    public byte DmgType3 { get; set; }

    public float DmgMin4 { get; set; }

    public float DmgMax4 { get; set; }

    public byte DmgType4 { get; set; }

    public float DmgMin5 { get; set; }

    public float DmgMax5 { get; set; }

    public byte DmgType5 { get; set; }

    public uint Block { get; set; }

    public short Armor { get; set; }

    public short HolyRes { get; set; }

    public short FireRes { get; set; }

    public short NatureRes { get; set; }

    public short FrostRes { get; set; }

    public short ShadowRes { get; set; }

    public short ArcaneRes { get; set; }

    public ushort Spellid1 { get; set; }

    public byte Spelltrigger1 { get; set; }

    public sbyte Spellcharges1 { get; set; }

    public float Spellppmrate1 { get; set; }

    public int Spellcooldown1 { get; set; }

    public ushort Spellcategory1 { get; set; }

    public int Spellcategorycooldown1 { get; set; }

    public ushort Spellid2 { get; set; }

    public byte Spelltrigger2 { get; set; }

    public sbyte Spellcharges2 { get; set; }

    public float Spellppmrate2 { get; set; }

    public int Spellcooldown2 { get; set; }

    public ushort Spellcategory2 { get; set; }

    public int Spellcategorycooldown2 { get; set; }

    public ushort Spellid3 { get; set; }

    public byte Spelltrigger3 { get; set; }

    public sbyte Spellcharges3 { get; set; }

    public float Spellppmrate3 { get; set; }

    public int Spellcooldown3 { get; set; }

    public ushort Spellcategory3 { get; set; }

    public int Spellcategorycooldown3 { get; set; }

    public ushort Spellid4 { get; set; }

    public byte Spelltrigger4 { get; set; }

    public sbyte Spellcharges4 { get; set; }

    public float Spellppmrate4 { get; set; }

    public int Spellcooldown4 { get; set; }

    public ushort Spellcategory4 { get; set; }

    public int Spellcategorycooldown4 { get; set; }

    public ushort Spellid5 { get; set; }

    public byte Spelltrigger5 { get; set; }

    public sbyte Spellcharges5 { get; set; }

    public float Spellppmrate5 { get; set; }

    public int Spellcooldown5 { get; set; }

    public ushort Spellcategory5 { get; set; }

    public int Spellcategorycooldown5 { get; set; }

    public byte Bonding { get; set; }

    public uint PageText { get; set; }

    public byte PageLanguage { get; set; }

    public byte PageMaterial { get; set; }

    public uint StartQuest { get; set; }

    public uint LockId { get; set; }

    public sbyte Material { get; set; }

    public byte Sheath { get; set; }

    public uint RandomProperty { get; set; }

    public uint SetId { get; set; }

    public ushort MaxDurability { get; set; }

    public uint AreaBound { get; set; }

    public short MapBound { get; set; }

    public uint Duration { get; set; }

    public int BagFamily { get; set; }

    public uint DisenchantId { get; set; }

    public byte FoodType { get; set; }

    public uint MinMoneyLoot { get; set; }

    public uint MaxMoneyLoot { get; set; }

    public uint WrappedGift { get; set; }

    public byte ExtraFlags { get; set; }

    public uint? OtherTeamEntry { get; set; }
}
