using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Guild System
/// </summary>
public partial class Guild
{
    public uint GuildId { get; set; }

    public string Name { get; set; } = null!;

    public uint LeaderGuid { get; set; }

    public int EmblemStyle { get; set; }

    public int EmblemColor { get; set; }

    public int BorderStyle { get; set; }

    public int BorderColor { get; set; }

    public int BackgroundColor { get; set; }

    public string Info { get; set; } = null!;

    public string Motd { get; set; } = null!;

    public long CreateDate { get; set; }
}
