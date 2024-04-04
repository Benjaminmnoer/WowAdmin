using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class CharacterInstance
{
    public uint Guid { get; set; }

    public uint Instance { get; set; }

    public byte Permanent { get; set; }
}
