using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PlayerFactionchangeMount
{
    public int RaceId { get; set; }

    public int MountNum { get; set; }

    public int ItemEntry { get; set; }

    public string Comment { get; set; } = null!;
}
