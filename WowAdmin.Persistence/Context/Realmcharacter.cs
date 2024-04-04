using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Realm Character Tracker
/// </summary>
public partial class Realmcharacter
{
    public uint Realmid { get; set; }

    public ulong Acctid { get; set; }

    public byte Numchars { get; set; }
}
