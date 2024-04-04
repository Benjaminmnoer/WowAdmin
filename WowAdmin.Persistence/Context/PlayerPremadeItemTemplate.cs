using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PlayerPremadeItemTemplate
{
    public uint Entry { get; set; }

    public byte Class { get; set; }

    public byte Level { get; set; }

    public byte Role { get; set; }

    public string? Name { get; set; }
}
