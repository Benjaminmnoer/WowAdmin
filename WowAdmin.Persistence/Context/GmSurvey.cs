using System;
using System.Collections.Generic;

namespace WowAdmin.Persistence.Context;

/// <summary>
/// Player System
/// </summary>
public partial class GmSurvey
{
    public uint SurveyId { get; set; }

    public uint Guid { get; set; }

    public uint MainSurvey { get; set; }

    public string OverallComment { get; set; } = null!;

    public uint CreateTime { get; set; }
}
