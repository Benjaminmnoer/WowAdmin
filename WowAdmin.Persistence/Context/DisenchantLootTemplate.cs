using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Loot System
/// </summary>
public partial class DisenchantLootTemplate
{
    /// <summary>
    /// Recommended id selection: item_level*100 + item_quality
    /// </summary>
    public uint Entry { get; set; }

    public uint Item { get; set; }

    public float ChanceOrQuestChance { get; set; }

    public byte Groupid { get; set; }

    public int MincountOrRef { get; set; }

    public byte Maxcount { get; set; }

    public uint ConditionId { get; set; }

    /// <summary>
    /// Minimum content patch to load this entry
    /// </summary>
    public byte PatchMin { get; set; }

    /// <summary>
    /// Maximum content patch to load this entry
    /// </summary>
    public byte PatchMax { get; set; }
}
