﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class EmployerMainBusinessType
{
    public int Oid { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public string? Code { get; set; }

    public string? NameTh { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual ICollection<EmployerBusinessType> EmployerBusinessTypes { get; set; } = new List<EmployerBusinessType>();

    public virtual ICollection<EmployerProfile> EmployerProfiles { get; set; } = new List<EmployerProfile>();
}