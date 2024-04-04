using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class CreatureGroupsEntryLimit
{
    public uint LeaderGuid { get; set; }

    public uint CreatureId { get; set; }

    public uint MinCount { get; set; }

    public uint MaxCount { get; set; }
}
