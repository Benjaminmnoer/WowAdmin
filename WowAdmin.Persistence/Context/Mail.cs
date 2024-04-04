using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Mail System
/// </summary>
public partial class Mail
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint Id { get; set; }

    public byte MessageType { get; set; }

    public sbyte Stationery { get; set; }

    public uint MailTemplateId { get; set; }

    /// <summary>
    /// Character Global Unique Identifier
    /// </summary>
    public uint SenderGuid { get; set; }

    /// <summary>
    /// Character Global Unique Identifier
    /// </summary>
    public uint ReceiverGuid { get; set; }

    public string? Subject { get; set; }

    public uint ItemTextId { get; set; }

    public byte HasItems { get; set; }

    public long ExpireTime { get; set; }

    public long DeliverTime { get; set; }

    public uint Money { get; set; }

    public uint Cod { get; set; }

    public byte Checked { get; set; }
}
