using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class ItemRequiredTarget
{
    public uint Entry { get; set; }

    public byte Type { get; set; }

    public uint TargetEntry { get; set; }
}
