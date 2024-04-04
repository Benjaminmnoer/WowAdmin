using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class GameobjectDisplayInfoAddon
{
    public int DisplayId { get; set; }

    public float MinX { get; set; }

    public float MinY { get; set; }

    public float MinZ { get; set; }

    public float MaxX { get; set; }

    public float MaxY { get; set; }

    public float MaxZ { get; set; }
}
