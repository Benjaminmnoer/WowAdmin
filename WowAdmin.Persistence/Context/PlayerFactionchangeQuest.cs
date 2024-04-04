using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PlayerFactionchangeQuest
{
    public int AllianceId { get; set; }

    public int HordeId { get; set; }

    public string Comment { get; set; } = null!;
}
