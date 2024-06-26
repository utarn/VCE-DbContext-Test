﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class District
{
    public int Oid { get; set; }

    public int? Province { get; set; }

    public string? DistrictId { get; set; }

    public string? DistrictThai { get; set; }

    public string? DistrictEng { get; set; }

    public string? DistrictThaiShort { get; set; }

    public string? DistrictEngShort { get; set; }

    public string? ProvinceId { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual ICollection<EmployerProfile> EmployerProfiles { get; set; } = new List<EmployerProfile>();

    public virtual ICollection<JobPosting> JobPostings { get; set; } = new List<JobPosting>();

    public virtual Province? ProvinceNavigation { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Tambon> Tambons { get; set; } = new List<Tambon>();
}