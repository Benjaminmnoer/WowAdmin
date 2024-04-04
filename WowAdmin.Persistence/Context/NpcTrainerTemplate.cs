using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class NpcTrainerTemplate
{
    public uint Entry { get; set; }

    public ushort Spell { get; set; }

    public uint Spellcost { get; set; }

    public ushort Reqskill { get; set; }

    public ushort Reqskillvalue { get; set; }

    public byte Reqlevel { get; set; }

    /// <summary>
    /// Minimum game client build to load this entry
    /// </summary>
    public ushort BuildMin { get; set; }

    /// <summary>
    /// Maximum game client build to load this entry
    /// </summary>
    public ushort BuildMax { get; set; }
}
