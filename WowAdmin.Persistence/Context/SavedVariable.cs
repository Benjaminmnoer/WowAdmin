using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Variable Saves
/// </summary>
public partial class SavedVariable
{
    public byte Key { get; set; }

    public uint CleaningFlags { get; set; }

    public uint HonorLastMaintenanceDay { get; set; }

    public uint HonorNextMaintenanceDay { get; set; }

    public byte HonorMaintenanceMarker { get; set; }
}
