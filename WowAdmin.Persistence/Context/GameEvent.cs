using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class GameEvent
{
    /// <summary>
    /// Entry of the game event
    /// </summary>
    public uint Entry { get; set; }

    /// <summary>
    /// Absolute start date, the event will never start before
    /// </summary>
    public DateTime StartTime { get; set; }

    /// <summary>
    /// Absolute end date, the event will never start afler
    /// </summary>
    public DateTime EndTime { get; set; }

    /// <summary>
    /// Delay in minutes between occurences of the event
    /// </summary>
    public ulong Occurence { get; set; }

    /// <summary>
    /// Length in minutes of the event
    /// </summary>
    public ulong Length { get; set; }

    /// <summary>
    /// Client side holiday id
    /// </summary>
    public uint Holiday { get; set; }

    /// <summary>
    /// Description of the event displayed in console
    /// </summary>
    public string? Description { get; set; }

    public sbyte Hardcoded { get; set; }

    public sbyte Disabled { get; set; }

    /// <summary>
    /// Minimum content patch to enable this event
    /// </summary>
    public byte PatchMin { get; set; }

    /// <summary>
    /// Maximum content patch to enable this event
    /// </summary>
    public byte PatchMax { get; set; }
}
