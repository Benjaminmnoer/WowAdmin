using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class AreaTemplate
{
    public uint Entry { get; set; }

    public uint MapId { get; set; }

    public uint ZoneId { get; set; }

    public uint ExploreFlag { get; set; }

    public uint Flags { get; set; }

    public int AreaLevel { get; set; }

    public string Name { get; set; } = null!;

    public byte Team { get; set; }

    public byte LiquidType { get; set; }
}
