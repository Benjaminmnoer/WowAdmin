using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Item System
/// </summary>
public partial class PageText
{
    public uint Entry { get; set; }

    public string Text { get; set; } = null!;

    public uint NextPage { get; set; }
}
