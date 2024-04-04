﻿using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterReputation
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public uint Faction { get; set; }

    public int Standing { get; set; }

    public int Flags { get; set; }
}
