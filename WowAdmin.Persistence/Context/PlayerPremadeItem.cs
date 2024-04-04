using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PlayerPremadeItem
{
    public uint Entry { get; set; }

    public uint Item { get; set; }

    public uint Enchant { get; set; }

    public uint Team { get; set; }
}
