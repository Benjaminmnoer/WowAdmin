using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class Instance
{
    public uint Id { get; set; }

    public uint Map { get; set; }

    public long ResetTime { get; set; }

    public string? Data { get; set; }
}
