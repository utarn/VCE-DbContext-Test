﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class XpoRunningWorkflowInstanceInfo
{
    public Guid Oid { get; set; }

    public string? WorkflowName { get; set; }

    public string? WorkflowUniqueId { get; set; }

    public string? TargetObjectHandle { get; set; }

    public Guid? ActivityInstanceId { get; set; }

    public string? State { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }
}