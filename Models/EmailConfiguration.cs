﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class EmailConfiguration
{
    public int Oid { get; set; }

    public string? FromEmailAddress { get; set; }

    public string? FromEmailDisplayName { get; set; }

    public string? Smtphost { get; set; }

    public int? Smtpport { get; set; }

    public bool? Smtpauthen { get; set; }

    public bool? Smtpssl { get; set; }

    public string? Smtpuser { get; set; }

    public string? Smtppassword { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }
}