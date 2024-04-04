using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class SpellArea
{
    public ushort Spell { get; set; }

    public uint Area { get; set; }

    public uint QuestStart { get; set; }

    public byte QuestStartActive { get; set; }

    public uint QuestEnd { get; set; }

    public short AuraSpell { get; set; }

    public uint Racemask { get; set; }

    public byte Gender { get; set; }

    public byte Autocast { get; set; }
}
