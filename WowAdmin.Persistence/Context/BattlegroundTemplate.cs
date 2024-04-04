using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class BattlegroundTemplate
{
    public uint Id { get; set; }

    /// <summary>
    /// Content patch in which this exact version of the entry was added
    /// </summary>
    public byte Patch { get; set; }

    public ushort MinPlayersPerTeam { get; set; }

    public ushort MaxPlayersPerTeam { get; set; }

    public byte MinLevel { get; set; }

    public byte MaxLevel { get; set; }

    public ushort AllianceWinSpell { get; set; }

    public ushort AllianceLoseSpell { get; set; }

    public ushort HordeWinSpell { get; set; }

    public ushort HordeLoseSpell { get; set; }

    /// <summary>
    /// WorldSafeLocs.dbc
    /// </summary>
    public uint AllianceStartLocation { get; set; }

    /// <summary>
    /// WorldSafeLocs.dbc
    /// </summary>
    public uint HordeStartLocation { get; set; }

    /// <summary>
    /// entry from reference_loot_template
    /// </summary>
    public uint PlayerLootId { get; set; }
}
