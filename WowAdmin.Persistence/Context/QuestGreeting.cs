using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class QuestGreeting
{
    public uint Entry { get; set; }

    public byte Type { get; set; }

    public string ContentDefault { get; set; } = null!;

    public string? ContentLoc1 { get; set; }

    public string? ContentLoc2 { get; set; }

    public string? ContentLoc3 { get; set; }

    public string? ContentLoc4 { get; set; }

    public string? ContentLoc5 { get; set; }

    public string? ContentLoc6 { get; set; }

    public string? ContentLoc7 { get; set; }

    public string? ContentLoc8 { get; set; }

    public ushort EmoteId { get; set; }

    public uint EmoteDelay { get; set; }
}
