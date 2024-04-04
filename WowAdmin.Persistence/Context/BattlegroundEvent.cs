using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class BattlegroundEvent
{
    public ushort Map { get; set; }

    public byte Event1 { get; set; }

    public byte Event2 { get; set; }

    public string Description { get; set; } = null!;
}
