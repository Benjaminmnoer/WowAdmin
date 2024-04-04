using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Player System
/// </summary>
public partial class GmTicket
{
    public uint TicketId { get; set; }

    /// <summary>
    /// Global Unique Identifier of ticket creator
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Name of ticket creator
    /// </summary>
    public string Name { get; set; } = null!;

    public string Message { get; set; } = null!;

    public ulong CreateTime { get; set; }

    public ushort Map { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public float PositionZ { get; set; }

    public ulong LastModifiedTime { get; set; }

    public int ClosedBy { get; set; }

    /// <summary>
    /// GUID of admin to whom ticket is assigned
    /// </summary>
    public uint AssignedTo { get; set; }

    public string Comment { get; set; } = null!;

    public string Response { get; set; } = null!;

    public byte Completed { get; set; }

    public byte Escalated { get; set; }

    public byte Viewed { get; set; }

    public byte HaveTicket { get; set; }

    public byte TicketType { get; set; }

    public byte SecurityNeeded { get; set; }
}
