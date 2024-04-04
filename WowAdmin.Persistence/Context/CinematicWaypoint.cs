using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class CinematicWaypoint
{
    public uint? Cinematic { get; set; }

    public uint? Timer { get; set; }

    public float? PositionX { get; set; }

    public float? PositionY { get; set; }

    public float? PositionZ { get; set; }

    public string? Comment { get; set; }
}
