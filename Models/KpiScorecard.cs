﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class KpiScorecard
{
    public Guid Oid { get; set; }

    public string? Name { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual ICollection<KpiScorecardScorecardsKpiInstanceIndicator> KpiScorecardScorecardsKpiInstanceIndicators { get; set; } = new List<KpiScorecardScorecardsKpiInstanceIndicator>();
}