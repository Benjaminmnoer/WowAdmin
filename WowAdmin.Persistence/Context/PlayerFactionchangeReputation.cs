using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PlayerFactionchangeReputation
{
    public int AllianceId { get; set; }

    public int HordeId { get; set; }
}
