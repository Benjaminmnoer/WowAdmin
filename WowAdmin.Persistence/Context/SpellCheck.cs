using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class SpellCheck
{
    public ushort Spellid { get; set; }

    public short SpellFamilyName { get; set; }

    public long SpellFamilyMask { get; set; }

    public int SpellIcon { get; set; }

    public int SpellVisual { get; set; }

    public int SpellCategory { get; set; }

    public int EffectType { get; set; }

    public int EffectAura { get; set; }

    public sbyte EffectIdx { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;
}
