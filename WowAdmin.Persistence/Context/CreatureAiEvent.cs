using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// EventAI Scripts
/// </summary>
public partial class CreatureAiEvent
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// Creature Template Identifier
    /// </summary>
    public uint CreatureId { get; set; }

    /// <summary>
    /// Condition id from conditions table
    /// </summary>
    public uint ConditionId { get; set; }

    /// <summary>
    /// Event Type
    /// </summary>
    public byte EventType { get; set; }

    /// <summary>
    /// Mask which phases this event will not trigger in
    /// </summary>
    public int EventInversePhaseMask { get; set; }

    public byte EventChance { get; set; }

    public uint EventFlags { get; set; }

    public int EventParam1 { get; set; }

    public int EventParam2 { get; set; }

    public int EventParam3 { get; set; }

    public int EventParam4 { get; set; }

    public uint Action1Script { get; set; }

    public uint Action2Script { get; set; }

    public uint Action3Script { get; set; }

    /// <summary>
    /// Event Comment
    /// </summary>
    public string Comment { get; set; } = null!;
}
