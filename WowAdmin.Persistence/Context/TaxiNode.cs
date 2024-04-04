using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class TaxiNode
{
    public ushort Id { get; set; }

    /// <summary>
    /// Game client build for which to load this entry
    /// </summary>
    public ushort Build { get; set; }

    public uint MapId { get; set; }

    public float X { get; set; }

    public float Y { get; set; }

    public float Z { get; set; }

    public string Name { get; set; } = null!;

    public ushort MountCreatureId1 { get; set; }

    public ushort MountCreatureId2 { get; set; }
}
