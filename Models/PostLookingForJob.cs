﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class PostLookingForJob
{
    public int Oid { get; set; }

    public int? Student { get; set; }

    public bool? Status { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual Student? StudentNavigation { get; set; }
}