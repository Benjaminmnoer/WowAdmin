using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Gameobject System
/// </summary>
public partial class GameobjectRequirement
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Gameobject Identifier
    /// </summary>
    public uint ReqType { get; set; }

    /// <summary>
    /// Gameobject Identifier
    /// </summary>
    public uint ReqGuid { get; set; }
}
