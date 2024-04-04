using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Guild System
/// </summary>
public partial class GuildRank
{
    public uint GuildId { get; set; }

    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public uint Rights { get; set; }
}
