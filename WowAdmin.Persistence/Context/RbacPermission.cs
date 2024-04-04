using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class RbacPermission
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;
}
