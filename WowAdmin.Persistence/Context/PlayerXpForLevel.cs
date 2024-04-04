using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PlayerXpForLevel
{
    public uint Lvl { get; set; }

    public uint XpForNextLevel { get; set; }
}
