﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class FileAttachment
{
    public int Oid { get; set; }

    public string? Filename { get; set; }

    public string? Realfilename { get; set; }

    public int? Size { get; set; }

    public string? Extension { get; set; }

    public string? Fullpath { get; set; }

    public string? Fileprefixpath { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual ICollection<EmployerFileAttachment> EmployerFileAttachments { get; set; } = new List<EmployerFileAttachment>();

    public virtual ICollection<StudentResume> StudentResumes { get; set; } = new List<StudentResume>();
}