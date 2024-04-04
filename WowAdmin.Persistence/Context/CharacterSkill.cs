using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterSkill
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public uint Skill { get; set; }

    public uint Value { get; set; }

    public uint Max { get; set; }
}
