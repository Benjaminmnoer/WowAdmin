using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class ScriptEscortDatum
{
    public int? CreatureId { get; set; }

    public int? Quest { get; set; }

    public int? EscortFaction { get; set; }
}
