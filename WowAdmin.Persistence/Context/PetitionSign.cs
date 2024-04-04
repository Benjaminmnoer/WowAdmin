using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Guild System
/// </summary>
public partial class PetitionSign
{
    public uint OwnerGuid { get; set; }

    public uint PetitionGuid { get; set; }

    public uint PlayerGuid { get; set; }

    public uint PlayerAccount { get; set; }
}
