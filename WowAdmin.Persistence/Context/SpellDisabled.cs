using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class SpellDisabled
{
    /// <summary>
    /// Disabled spell
    /// </summary>
    public ushort Entry { get; set; }
}
