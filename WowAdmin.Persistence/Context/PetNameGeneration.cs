using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PetNameGeneration
{
    public uint Id { get; set; }

    public string Word { get; set; } = null!;

    public uint Entry { get; set; }

    public sbyte Half { get; set; }
}
