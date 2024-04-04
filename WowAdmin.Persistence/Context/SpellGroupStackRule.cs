using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class SpellGroupStackRule
{
    public uint GroupId { get; set; }

    /// <summary>
    /// Game client build in which this exact stacking rule was added
    /// </summary>
    public ushort Build { get; set; }

    public sbyte StackRule { get; set; }
}
