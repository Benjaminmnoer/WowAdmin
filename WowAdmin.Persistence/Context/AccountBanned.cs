using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Ban List
/// </summary>
public partial class AccountBanned
{
    public long Banid { get; set; }

    /// <summary>
    /// Account id
    /// </summary>
    public long Id { get; set; }

    public long Bandate { get; set; }

    public long Unbandate { get; set; }

    public string Bannedby { get; set; } = null!;

    public string Banreason { get; set; } = null!;

    public sbyte Active { get; set; }

    public sbyte Realm { get; set; }

    public byte Gmlevel { get; set; }
}
