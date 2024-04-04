using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class PetSpellDatum
{
    public uint Entry { get; set; }

    public ushort Build { get; set; }

    public ushort SpellId1 { get; set; }

    public ushort SpellId2 { get; set; }

    public ushort SpellId3 { get; set; }

    public ushort SpellId4 { get; set; }
}
