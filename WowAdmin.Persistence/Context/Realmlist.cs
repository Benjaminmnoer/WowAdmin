using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Realm System
/// </summary>
public partial class Realmlist
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string LocalAddress { get; set; } = null!;

    public string LocalSubnetMask { get; set; } = null!;

    public int Port { get; set; }

    public byte Icon { get; set; }

    public byte Realmflags { get; set; }

    public byte Timezone { get; set; }

    public byte AllowedSecurityLevel { get; set; }

    public uint GamebuildMin { get; set; }

    public uint GamebuildMax { get; set; }

    public byte Flag { get; set; }

    public string Realmbuilds { get; set; } = null!;
}
