﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class PropertyValue
{
    public Guid Oid { get; set; }

    public Guid? Descriptor { get; set; }

    public Guid? Bag { get; set; }

    public string? StrValue { get; set; }

    public Guid? WeakReference { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual PropertyBag? BagNavigation { get; set; }

    public virtual PropertyDescriptor? DescriptorNavigation { get; set; }

    public virtual XpweakReference? WeakReferenceNavigation { get; set; }
}