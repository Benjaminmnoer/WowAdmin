using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Game event system
/// </summary>
public partial class GameEventQuest
{
    /// <summary>
    /// entry from quest_template
    /// </summary>
    public uint Quest { get; set; }

    /// <summary>
    /// entry from game_event
    /// </summary>
    public ushort Event { get; set; }

    /// <summary>
    /// Minimum content patch to load this entry
    /// </summary>
    public byte PatchMin { get; set; }
}
