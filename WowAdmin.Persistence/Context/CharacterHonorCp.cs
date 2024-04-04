using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterHonorCp
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Object Type Id
    /// </summary>
    public byte VictimType { get; set; }

    /// <summary>
    /// Creature Id / Player Guid
    /// </summary>
    public uint VictimId { get; set; }

    public float Cp { get; set; }

    public uint Date { get; set; }

    public byte Type { get; set; }
}
