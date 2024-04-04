using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class MailItem
{
    public uint MailId { get; set; }

    public uint ItemGuid { get; set; }

    public uint ItemId { get; set; }

    /// <summary>
    /// Character Global Unique Identifier
    /// </summary>
    public uint ReceiverGuid { get; set; }
}
