﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class PermissionPolicyNavigationPermissionsObject
{
    public Guid Oid { get; set; }

    public string? ItemPath { get; set; }

    public int? NavigateState { get; set; }

    public Guid? Role { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual PermissionPolicyRole? RoleNavigation { get; set; }
}