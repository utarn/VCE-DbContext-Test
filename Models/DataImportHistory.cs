﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class DataImportHistory
{
    public int Oid { get; set; }

    public string? ReferenceName { get; set; }

    public string? ReferenceKey { get; set; }

    public DateTime? LastImportDatetime { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }
}