﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class XpobjectType
{
    public int Oid { get; set; }

    public string? TypeName { get; set; }

    public string? AssemblyName { get; set; }

    public virtual ICollection<Party> Parties { get; set; } = new List<Party>();

    public virtual ICollection<PermissionPolicyRole> PermissionPolicyRoles { get; set; } = new List<PermissionPolicyRole>();

    public virtual ICollection<PermissionPolicyUser> PermissionPolicyUsers { get; set; } = new List<PermissionPolicyUser>();

    public virtual ICollection<XpweakReference> XpweakReferenceObjectTypeNavigations { get; set; } = new List<XpweakReference>();

    public virtual ICollection<XpweakReference> XpweakReferenceTargetTypeNavigations { get; set; } = new List<XpweakReference>();
}