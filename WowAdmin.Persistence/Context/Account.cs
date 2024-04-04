using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Account System
/// </summary>
public partial class Account
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint Id { get; set; }

    public string Username { get; set; } = null!;

    public byte Gmlevel { get; set; }

    public string? Sessionkey { get; set; }

    public string? V { get; set; }

    public string? S { get; set; }

    public string TokenKey { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime Joindate { get; set; }

    public string LastIp { get; set; } = null!;

    public uint FailedLogins { get; set; }

    public byte Locked { get; set; }

    public string LockCountry { get; set; } = null!;

    public DateTime LastLogin { get; set; }

    public sbyte Online { get; set; }

    public byte Expansion { get; set; }

    public long Mutetime { get; set; }

    public byte Locale { get; set; }

    public string Os { get; set; } = null!;

    public string Platform { get; set; } = null!;

    public byte CurrentRealm { get; set; }

    public uint Flags { get; set; }

    public string? Security { get; set; }

    /// <summary>
    /// Email verification
    /// </summary>
    public bool EmailVerif { get; set; }

    public int? GeolockPin { get; set; }
}
