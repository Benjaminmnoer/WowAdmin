using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class NpcTrainerGreeting
{
    public uint Entry { get; set; }

    public string ContentDefault { get; set; } = null!;

    public string ContentLoc1 { get; set; } = null!;

    public string ContentLoc2 { get; set; } = null!;

    public string ContentLoc3 { get; set; } = null!;

    public string ContentLoc4 { get; set; } = null!;

    public string ContentLoc5 { get; set; } = null!;

    public string ContentLoc6 { get; set; } = null!;

    public string ContentLoc7 { get; set; } = null!;

    public string ContentLoc8 { get; set; } = null!;
}
