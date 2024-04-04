using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class MapLootDisabled
{
    public int MapId { get; set; }

    public string? Comment { get; set; }
}
