using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class BroadcastText
{
    public uint Entry { get; set; }

    public string? MaleText { get; set; }

    public string? FemaleText { get; set; }

    public byte ChatType { get; set; }

    public ushort SoundId { get; set; }

    public byte LanguageId { get; set; }

    public ushort EmoteId1 { get; set; }

    public ushort EmoteId2 { get; set; }

    public ushort EmoteId3 { get; set; }

    public uint EmoteDelay1 { get; set; }

    public uint EmoteDelay2 { get; set; }

    public uint EmoteDelay3 { get; set; }
}
