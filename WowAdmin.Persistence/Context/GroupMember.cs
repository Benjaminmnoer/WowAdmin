using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Groups
/// </summary>
public partial class GroupMember
{
    public uint GroupId { get; set; }

    public uint MemberGuid { get; set; }

    public byte Assistant { get; set; }

    public ushort Subgroup { get; set; }
}
