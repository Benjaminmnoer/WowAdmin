using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class CharacterGift
{
    public uint Guid { get; set; }

    public uint ItemGuid { get; set; }

    public uint ItemId { get; set; }

    public uint Flags { get; set; }
}
