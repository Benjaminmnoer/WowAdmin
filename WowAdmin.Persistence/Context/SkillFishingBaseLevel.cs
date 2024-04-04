using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Fishing system
/// </summary>
public partial class SkillFishingBaseLevel
{
    /// <summary>
    /// Area identifier
    /// </summary>
    public uint Entry { get; set; }

    /// <summary>
    /// Base skill level requirement
    /// </summary>
    public short Skill { get; set; }
}
