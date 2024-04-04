using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PlayerFactionchangeSpell
{
    public ushort AllianceId { get; set; }

    public ushort HordeId { get; set; }

    public string Comment { get; set; } = null!;
}
