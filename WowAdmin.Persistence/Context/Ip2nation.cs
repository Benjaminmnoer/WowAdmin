using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class Ip2nation
{
    public uint Ip { get; set; }

    public string Country { get; set; } = null!;
}
