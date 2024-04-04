using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class InstanceReset
{
    public uint Map { get; set; }

    public long ResetTime { get; set; }
}
