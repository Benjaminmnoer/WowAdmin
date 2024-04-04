using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class WardenScan
{
    public ushort Id { get; set; }

    public int? Type { get; set; }

    public string? Str { get; set; }

    public string? Data { get; set; }

    public int? Address { get; set; }

    public int? Length { get; set; }

    public string Result { get; set; } = null!;

    public uint Flags { get; set; }

    /// <summary>
    /// Action to take if check fails
    /// </summary>
    public sbyte Penalty { get; set; }

    public ushort BuildMin { get; set; }

    public ushort BuildMax { get; set; }

    public string Comment { get; set; } = null!;
}
