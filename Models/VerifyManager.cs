﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class VerifyManager
{
    public int Oid { get; set; }

    public int? TitleName { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Position { get; set; }

    public string? SchoolId { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual ICollection<GraduatedStudentJobTrackingReport> GraduatedStudentJobTrackingReports { get; set; } = new List<GraduatedStudentJobTrackingReport>();

    public virtual TitleName? TitleNameNavigation { get; set; }
}