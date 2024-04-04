using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Player System
/// </summary>
public partial class GmSubsurvey
{
    public uint SurveyId { get; set; }

    public uint SubsurveyId { get; set; }

    public uint Rank { get; set; }

    public string Comment { get; set; } = null!;
}
