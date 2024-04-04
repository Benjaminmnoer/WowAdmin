﻿using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Creature System
/// </summary>
public partial class CreatureMovement
{
    /// <summary>
    /// Creature GUID
    /// </summary>
    public uint Id { get; set; }

    public uint Point { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public float PositionZ { get; set; }

    public float Orientation { get; set; }

    public uint Waittime { get; set; }

    public uint ScriptId { get; set; }

    public uint PathId { get; set; }
}
