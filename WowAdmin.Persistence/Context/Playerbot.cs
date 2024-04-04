using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class Playerbot
{
    public ulong CharGuid { get; set; }

    public uint Chance { get; set; }

    public string? Comment { get; set; }

    public string? Ai { get; set; }
}
