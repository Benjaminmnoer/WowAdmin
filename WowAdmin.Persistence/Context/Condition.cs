using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Condition System
/// </summary>
public partial class Condition
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint ConditionEntry { get; set; }

    /// <summary>
    /// Type of the condition
    /// </summary>
    public sbyte Type { get; set; }

    /// <summary>
    /// data field one for the condition
    /// </summary>
    public int Value1 { get; set; }

    /// <summary>
    /// data field two for the condition
    /// </summary>
    public int Value2 { get; set; }

    /// <summary>
    /// data field three for the condition
    /// </summary>
    public int Value3 { get; set; }

    /// <summary>
    /// data field four for the condition
    /// </summary>
    public int Value4 { get; set; }

    /// <summary>
    /// general condition flags
    /// </summary>
    public byte Flags { get; set; }
}
