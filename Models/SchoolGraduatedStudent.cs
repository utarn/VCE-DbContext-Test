﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class SchoolGraduatedStudent
{
    public int Oid { get; set; }

    public string? GraduatedYearTh { get; set; }

    public string? GraduatedSemesters { get; set; }

    public int? School { get; set; }

    public string? SchoolCode { get; set; }

    public int? QuantityOfGraduatedStudent { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual ICollection<GraduatedStudent> GraduatedStudents { get; set; } = new List<GraduatedStudent>();

    public virtual School? SchoolNavigation { get; set; }
}