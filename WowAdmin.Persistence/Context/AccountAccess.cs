using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class AccountAccess
{
    public uint Id { get; set; }

    public byte Gmlevel { get; set; }

    public int RealmId { get; set; }
}
