using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Creature OnKill Reputation gain
/// </summary>
public partial class CreatureOnkillReputation
{
    /// <summary>
    /// Creature Identifier
    /// </summary>
    public uint CreatureId { get; set; }

    /// <summary>
    /// Content patch in which this exact version of the entry was added
    /// </summary>
    public byte Patch { get; set; }

    public short RewOnKillRepFaction1 { get; set; }

    public short RewOnKillRepFaction2 { get; set; }

    public sbyte MaxStanding1 { get; set; }

    public sbyte IsTeamAward1 { get; set; }

    public int RewOnKillRepValue1 { get; set; }

    public sbyte MaxStanding2 { get; set; }

    public sbyte IsTeamAward2 { get; set; }

    public int RewOnKillRepValue2 { get; set; }

    public byte TeamDependent { get; set; }
}
