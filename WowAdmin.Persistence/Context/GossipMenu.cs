using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class GossipMenu
{
    public ushort Entry { get; set; }

    public uint TextId { get; set; }

    public uint ScriptId { get; set; }

    public uint ConditionId { get; set; }
}
