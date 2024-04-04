using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Creature System
/// </summary>
public partial class CreatureInvolvedrelation
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// Quest Identifier
    /// </summary>
    public uint Quest { get; set; }

    /// <summary>
    /// Minimum content patch to load this entry
    /// </summary>
    public byte PatchMin { get; set; }

    /// <summary>
    /// Maximum content patch to load this entry
    /// </summary>
    public byte PatchMax { get; set; }
}
