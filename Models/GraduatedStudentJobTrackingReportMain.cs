﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class GraduatedStudentJobTrackingReportMain
{
    public int Oid { get; set; }

    public string? TargetGraduatedYearTh { get; set; }

    public int? RoundNumber { get; set; }

    public string? Description { get; set; }

    public DateTime? TrackingStartDate { get; set; }

    public DateTime? TrackingEndDate { get; set; }

    public bool? IsImportStudentProcessStarted { get; set; }

    public int? ImportStudentDataStatus { get; set; }

    public DateTime? ImportStudentDataStatusUpdatedDate { get; set; }

    public int? JobTrackingStatus { get; set; }

    public DateTime? JobTrackingStatusUpdatedDate { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual ICollection<GraduatedStudentJobTrackingReport> GraduatedStudentJobTrackingReports { get; set; } = new List<GraduatedStudentJobTrackingReport>();

    public virtual EntityStatus? ImportStudentDataStatusNavigation { get; set; }

    public virtual EntityStatus? JobTrackingStatusNavigation { get; set; }
}