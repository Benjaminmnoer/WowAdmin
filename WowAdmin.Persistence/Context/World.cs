using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class World
{
    public uint Map { get; set; }

    public string? Data { get; set; }
}
