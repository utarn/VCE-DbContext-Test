﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class FileDatum
{
    public Guid Oid { get; set; }

    public int? Size { get; set; }

    public string? FileName { get; set; }

    public byte[]? Content { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }
}