using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class Faction
{
    public ushort Id { get; set; }

    /// <summary>
    /// Game client build for which to load this entry
    /// </summary>
    public ushort Build { get; set; }

    public int ReputationListId { get; set; }

    public uint BaseRepRaceMask1 { get; set; }

    public uint BaseRepRaceMask2 { get; set; }

    public uint BaseRepRaceMask3 { get; set; }

    public uint BaseRepRaceMask4 { get; set; }

    public uint BaseRepClassMask1 { get; set; }

    public uint BaseRepClassMask2 { get; set; }

    public uint BaseRepClassMask3 { get; set; }

    public uint BaseRepClassMask4 { get; set; }

    public int BaseRepValue1 { get; set; }

    public int BaseRepValue2 { get; set; }

    public int BaseRepValue3 { get; set; }

    public int BaseRepValue4 { get; set; }

    public uint ReputationFlags1 { get; set; }

    public uint ReputationFlags2 { get; set; }

    public uint ReputationFlags3 { get; set; }

    public uint ReputationFlags4 { get; set; }

    public uint Team { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
}
