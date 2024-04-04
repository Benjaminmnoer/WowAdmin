using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class SoundEntry
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;
}
