using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Trigger System
/// </summary>
public partial class AreatriggerTavern
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint Id { get; set; }

    public string? Name { get; set; }

    /// <summary>
    /// Minimum content patch to load this entry
    /// </summary>
    public byte PatchMin { get; set; }
}
