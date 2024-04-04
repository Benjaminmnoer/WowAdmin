using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class GossipScript
{
    public uint Id { get; set; }

    public uint Delay { get; set; }

    public byte Priority { get; set; }

    public byte Command { get; set; }

    public uint Datalong { get; set; }

    public uint Datalong2 { get; set; }

    public uint Datalong3 { get; set; }

    public uint Datalong4 { get; set; }

    public uint TargetParam1 { get; set; }

    public uint TargetParam2 { get; set; }

    public byte TargetType { get; set; }

    public byte DataFlags { get; set; }

    public int Dataint { get; set; }

    public int Dataint2 { get; set; }

    public int Dataint3 { get; set; }

    public int Dataint4 { get; set; }

    public float X { get; set; }

    public float Y { get; set; }

    public float Z { get; set; }

    public float O { get; set; }

    public uint ConditionId { get; set; }

    public string Comments { get; set; } = null!;
}
