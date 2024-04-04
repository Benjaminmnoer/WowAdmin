using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class Auction
{
    public uint Id { get; set; }

    public uint HouseId { get; set; }

    public uint ItemGuid { get; set; }

    public uint ItemId { get; set; }

    public uint SellerGuid { get; set; }

    public int BuyoutPrice { get; set; }

    public long ExpireTime { get; set; }

    public uint BuyerGuid { get; set; }

    public int LastBid { get; set; }

    public int StartBid { get; set; }

    public int Deposit { get; set; }
}
