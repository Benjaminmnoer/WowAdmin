using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PlayerPremadeSpell
{
    public uint Entry { get; set; }

    public ushort Spell { get; set; }
}
