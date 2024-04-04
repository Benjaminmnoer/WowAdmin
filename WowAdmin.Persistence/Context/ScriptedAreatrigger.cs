using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class ScriptedAreatrigger
{
    public int Entry { get; set; }

    public string ScriptName { get; set; } = null!;
}
