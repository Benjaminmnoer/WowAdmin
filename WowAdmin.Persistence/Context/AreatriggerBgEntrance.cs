using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class AreatriggerBgEntrance
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint Id { get; set; }

    public string? Name { get; set; }

    public uint Team { get; set; }

    public uint BgTemplate { get; set; }

    public ushort ExitMap { get; set; }

    public float ExitPositionX { get; set; }

    public float ExitPositionY { get; set; }

    public float ExitPositionZ { get; set; }

    public float ExitOrientation { get; set; }
}
