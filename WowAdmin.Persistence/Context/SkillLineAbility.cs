using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class SkillLineAbility
{
    public ushort Id { get; set; }

    /// <summary>
    /// Game client build for which to load this entry
    /// </summary>
    public ushort Build { get; set; }

    public uint SkillId { get; set; }

    public ushort SpellId { get; set; }

    public uint RaceMask { get; set; }

    public uint ClassMask { get; set; }

    public uint ReqSkillValue { get; set; }

    public ushort SupersededBySpell { get; set; }

    public uint LearnOnGetSkill { get; set; }

    public uint MaxValue { get; set; }

    public uint MinValue { get; set; }

    public uint ReqTrainPoints { get; set; }
}
