using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class CharacterAccountDatum
{
    public uint Guid { get; set; }

    public uint Type { get; set; }

    public ulong Time { get; set; }

    public byte[] Data { get; set; } = null!;
}
