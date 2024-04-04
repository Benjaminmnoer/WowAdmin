using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class AreatriggerTemplate
{
    public ushort Id { get; set; }

    /// <summary>
    /// Game client build for which to load this entry
    /// </summary>
    public ushort Build { get; set; }

    public ushort MapId { get; set; }

    public float X { get; set; }

    public float Y { get; set; }

    public float Z { get; set; }

    public float Radius { get; set; }

    public float BoxX { get; set; }

    public float BoxY { get; set; }

    public float BoxZ { get; set; }

    public float BoxOrientation { get; set; }
}
