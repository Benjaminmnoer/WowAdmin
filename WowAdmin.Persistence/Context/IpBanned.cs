using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Banned IPs
/// </summary>
public partial class IpBanned
{
    public string Ip { get; set; } = null!;

    public int Bandate { get; set; }

    public int Unbandate { get; set; }

    public string Bannedby { get; set; } = null!;

    public string Banreason { get; set; } = null!;
}
