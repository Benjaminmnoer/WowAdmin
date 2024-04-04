using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class RbacCommandPermission
{
    public string Command { get; set; } = null!;

    public uint PermissionId { get; set; }
}
