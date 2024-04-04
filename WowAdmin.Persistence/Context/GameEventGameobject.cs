using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class GameEventGameobject
{
    public uint Guid { get; set; }

    /// <summary>
    /// Put negatives values to remove during event
    /// </summary>
    public short Event { get; set; }
}
