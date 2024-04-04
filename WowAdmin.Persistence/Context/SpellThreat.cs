using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class SpellThreat
{
    public ushort Entry { get; set; }

    public float Threat { get; set; }

    /// <summary>
    /// threat multiplier for damage/healing
    /// </summary>
    public float Multiplier { get; set; }

    /// <summary>
    /// additional threat bonus from attack power
    /// </summary>
    public float ApBonus { get; set; }

    /// <summary>
    /// Minimum game client build to load this entry
    /// </summary>
    public ushort BuildMin { get; set; }

    /// <summary>
    /// Maximum game client build to load this entry
    /// </summary>
    public ushort BuildMax { get; set; }
}
