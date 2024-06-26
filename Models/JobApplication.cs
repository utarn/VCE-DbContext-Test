﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class JobApplication
{
    public int Oid { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? JobPosting { get; set; }

    public int? Student { get; set; }

    public int? JobApplicationStatus { get; set; }

    public DateTime? JobApplicationStatusUpdatedDate { get; set; }

    public DateTime? InterviewDate { get; set; }

    public string? InterviewTime { get; set; }

    public string? InterviewLocation { get; set; }

    public string? NotifyMessage { get; set; }

    public bool? IsRead { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual EntityStatus? JobApplicationStatusNavigation { get; set; }

    public virtual JobPosting? JobPostingNavigation { get; set; }

    public virtual Student? StudentNavigation { get; set; }
}