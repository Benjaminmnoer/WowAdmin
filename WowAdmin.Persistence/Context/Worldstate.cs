using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class Worldstate
{
    public int? Entry { get; set; }

    public int? Value { get; set; }

    public string? Comment { get; set; }
}
