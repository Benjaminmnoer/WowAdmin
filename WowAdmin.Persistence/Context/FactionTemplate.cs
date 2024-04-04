using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class FactionTemplate
{
    public ushort Id { get; set; }

    /// <summary>
    /// Game client build for which to load this entry
    /// </summary>
    public ushort Build { get; set; }

    public uint FactionId { get; set; }

    public uint FactionFlags { get; set; }

    public uint OurMask { get; set; }

    public uint FriendlyMask { get; set; }

    public uint HostileMask { get; set; }

    public uint EnemyFaction1 { get; set; }

    public uint EnemyFaction2 { get; set; }

    public uint EnemyFaction3 { get; set; }

    public uint EnemyFaction4 { get; set; }

    public uint FriendFaction1 { get; set; }

    public uint FriendFaction2 { get; set; }

    public uint FriendFaction3 { get; set; }

    public uint FriendFaction4 { get; set; }
}
