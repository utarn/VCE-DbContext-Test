﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class KpiDefinition
{
    public Guid Oid { get; set; }

    public string? TargetObjectType { get; set; }

    public DateTime? Changed { get; set; }

    public Guid? KpiInstance { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public string? Criteria { get; set; }

    public string? Expression { get; set; }

    public float? GreenZone { get; set; }

    public float? RedZone { get; set; }

    public string? Range { get; set; }

    public bool? Compare { get; set; }

    public string? RangeToCompare { get; set; }

    public int? MeasurementFrequency { get; set; }

    public int? MeasurementMode { get; set; }

    public int? Direction { get; set; }

    public DateTime? ChangedOn { get; set; }

    public string? SuppressedSeries { get; set; }

    public bool? EnableCustomizeRepresentation { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual KpiInstance? KpiInstanceNavigation { get; set; }

    public virtual ICollection<KpiInstance> KpiInstances { get; set; } = new List<KpiInstance>();
}