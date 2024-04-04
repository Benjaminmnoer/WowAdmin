using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Guild System
/// </summary>
public partial class GuildMember
{
    public uint GuildId { get; set; }

    public uint Guid { get; set; }

    public byte Rank { get; set; }

    public string PlayerNote { get; set; } = null!;

    public string OfficerNote { get; set; } = null!;
}
