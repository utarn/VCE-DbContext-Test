﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class Industry
{
    public int Oid { get; set; }

    public string? IndustryCode { get; set; }

    public string? IndustryId { get; set; }

    public string? IndustryNameEn { get; set; }

    public string? IndustryNameTh { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual ICollection<IndustryAndMinorMatching> IndustryAndMinorMatchings { get; set; } = new List<IndustryAndMinorMatching>();
}