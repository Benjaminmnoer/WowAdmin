using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterQueststatus
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Quest Identifier
    /// </summary>
    public uint Quest { get; set; }

    public uint Status { get; set; }

    public byte Rewarded { get; set; }

    public byte Explored { get; set; }

    public ulong Timer { get; set; }

    public uint MobCount1 { get; set; }

    public uint MobCount2 { get; set; }

    public uint MobCount3 { get; set; }

    public uint MobCount4 { get; set; }

    public uint ItemCount1 { get; set; }

    public uint ItemCount2 { get; set; }

    public uint ItemCount3 { get; set; }

    public uint ItemCount4 { get; set; }

    public uint RewardChoice { get; set; }
}
