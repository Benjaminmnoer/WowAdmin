using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Guild System
/// </summary>
public partial class Petition
{
    public uint OwnerGuid { get; set; }

    public uint? PetitionGuid { get; set; }

    /// <summary>
    /// Charter item GUID
    /// </summary>
    public uint? CharterGuid { get; set; }

    public string Name { get; set; } = null!;
}
