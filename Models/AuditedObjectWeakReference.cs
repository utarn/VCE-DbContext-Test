﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class AuditedObjectWeakReference
{
    public Guid Oid { get; set; }

    public Guid? GuidId { get; set; }

    public int? IntId { get; set; }

    public string? DisplayName { get; set; }

    public virtual ICollection<AuditDataItemPersistent> AuditDataItemPersistents { get; set; } = new List<AuditDataItemPersistent>();

    public virtual XpweakReference OidNavigation { get; set; } = null!;
}