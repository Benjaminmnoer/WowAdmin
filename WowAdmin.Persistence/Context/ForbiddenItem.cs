using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class ForbiddenItem
{
    public uint Entry { get; set; }

    public byte Patch { get; set; }

    public byte AfterOrBefore { get; set; }
}
