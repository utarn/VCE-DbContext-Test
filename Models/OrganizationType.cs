﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class OrganizationType
{
    public int Oid { get; set; }

    public string? Code { get; set; }

    public string? NameTh { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual ICollection<StudentJobRecord> StudentJobRecords { get; set; } = new List<StudentJobRecord>();
}