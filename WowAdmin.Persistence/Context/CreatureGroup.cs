using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class CreatureGroup
{
    public uint LeaderGuid { get; set; }

    public uint MemberGuid { get; set; }

    public uint Flags { get; set; }
}
