using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class SpellEnchantCharge
{
    public ushort Entry { get; set; }

    public uint Charges { get; set; }
}
