using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class AllowedClient
{
    public byte MajorVersion { get; set; }

    public byte MinorVersion { get; set; }

    public byte BugfixVersion { get; set; }

    public string HotfixVersion { get; set; } = null!;

    public uint Build { get; set; }

    public string Os { get; set; } = null!;

    public string Platform { get; set; } = null!;

    public string IntegrityHash { get; set; } = null!;
}
