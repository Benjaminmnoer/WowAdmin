using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class CharacterDeletedItem
{
    public uint Id { get; set; }

    public uint PlayerGuid { get; set; }

    public uint ItemId { get; set; }

    public uint StackCount { get; set; }
}
