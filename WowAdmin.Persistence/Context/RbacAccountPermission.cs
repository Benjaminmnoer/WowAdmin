using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

public partial class RbacAccountPermission
{
    public int AccountId { get; set; }

    public int PermissionId { get; set; }

    public byte Granted { get; set; }
}
