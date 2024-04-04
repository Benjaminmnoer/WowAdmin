using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PlayercreateinfoSpell
{
    public byte Race { get; set; }

    public byte Class { get; set; }

    public ushort Spell { get; set; }

    /// <summary>
    /// Minimum game client build to load this entry
    /// </summary>
    public ushort BuildMin { get; set; }

    /// <summary>
    /// Maximum game client build to load this entry
    /// </summary>
    public ushort BuildMax { get; set; }

    public string? Note { get; set; }
}
