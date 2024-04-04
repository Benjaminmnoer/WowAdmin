using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Guild Eventlog
/// </summary>
public partial class GuildEventlog
{
    /// <summary>
    /// Guild Identificator
    /// </summary>
    public int GuildId { get; set; }

    /// <summary>
    /// Log record identificator - auxiliary column
    /// </summary>
    public int LogGuid { get; set; }

    /// <summary>
    /// Event type
    /// </summary>
    public bool EventType { get; set; }

    /// <summary>
    /// Player 1
    /// </summary>
    public int PlayerGuid1 { get; set; }

    /// <summary>
    /// Player 2
    /// </summary>
    public int PlayerGuid2 { get; set; }

    /// <summary>
    /// New rank(in case promotion/demotion)
    /// </summary>
    public sbyte NewRank { get; set; }

    /// <summary>
    /// Event UNIX time
    /// </summary>
    public long Timestamp { get; set; }
}
