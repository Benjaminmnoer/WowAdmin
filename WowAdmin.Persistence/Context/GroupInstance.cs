using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class GroupInstance
{
    public uint LeaderGuid { get; set; }

    public uint Instance { get; set; }

    public byte Permanent { get; set; }
}
