using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class Auctionhousebot
{
    /// <summary>
    /// Item Id
    /// </summary>
    public uint Item { get; set; }

    /// <summary>
    /// Stack Size
    /// </summary>
    public byte Stack { get; set; }

    /// <summary>
    /// Bid Price
    /// </summary>
    public uint Bid { get; set; }

    /// <summary>
    /// Buyout Price
    /// </summary>
    public uint Buyout { get; set; }
}
