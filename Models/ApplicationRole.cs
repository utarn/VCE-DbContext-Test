﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class ApplicationRole
{
    public Guid Oid { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public virtual PermissionPolicyRole OidNavigation { get; set; } = null!;
}