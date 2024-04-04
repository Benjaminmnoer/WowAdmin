using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class MapTemplate
{
    public ushort Entry { get; set; }

    /// <summary>
    /// Content patch in which this exact version of the entry was added
    /// </summary>
    public byte Patch { get; set; }

    public uint Parent { get; set; }

    public byte MapType { get; set; }

    public uint LinkedZone { get; set; }

    public byte PlayerLimit { get; set; }

    public uint ResetDelay { get; set; }

    public short GhostEntranceMap { get; set; }

    public float GhostEntranceX { get; set; }

    public float GhostEntranceY { get; set; }

    public string MapName { get; set; } = null!;

    public string ScriptName { get; set; } = null!;
}
