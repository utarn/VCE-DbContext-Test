﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class ModificationInfo
{
    public int Oid { get; set; }

    public string? PropertyName { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public int? Audit { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual Audit? AuditNavigation { get; set; }
}