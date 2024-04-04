using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class NpcGossip
{
    public uint NpcGuid { get; set; }

    public uint Textid { get; set; }
}
