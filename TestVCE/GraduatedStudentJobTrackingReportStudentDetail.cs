﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class GraduatedStudentJobTrackingReportStudentDetail
{
    public int Oid { get; set; }

    public int? GraduatedStudentJobTrackingReport { get; set; }

    public int? Student { get; set; }

    public string? CorporationTaxId { get; set; }

    public string? CorporationName { get; set; }

    public string? JobPositionCode { get; set; }

    public string? JobPositionName { get; set; }

    public string? SalaryRange { get; set; }

    public string? SchoolName { get; set; }

    public string? OtherDescription { get; set; }

    public string? UnknownRemark { get; set; }

    public string? Major { get; set; }

    public string? Minor { get; set; }

    public string? Jobdescription { get; set; }

    public string? TrackingYearTh { get; set; }

    public string? Semester { get; set; }

    public int? ContinuetoStudyLevel { get; set; }

    public int? EmploymentStatus { get; set; }

    public string? EmploymentStatusName { get; set; }

    public int? ContinueToStudyInRelatedFieldStatus { get; set; }

    public string? ContinueToStudyInRelatedFieldStatusName { get; set; }

    public int? StudyCourseType { get; set; }

    public string? StudyCourseTypeName { get; set; }

    public DateTime? EditDate { get; set; }

    public int? GettingJobThatRelatedWithStudiedFieldStatus { get; set; }

    public string? GettingJobThatRelatedWithStudiedFieldStatusName { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public string? SchoolId { get; set; }

    public string? EmployerSummaryOid { get; set; }

    public int? StudentVeceducationInformation { get; set; }

    // public virtual EmploymentStatus? EmploymentStatusNavigation { get; set; }
    //
    // public virtual GraduatedStudentJobTrackingReport? GraduatedStudentJobTrackingReportNavigation { get; set; }
    //
    // public virtual Student? StudentNavigation { get; set; }
    //
    // public virtual StudentVeceducationInformation? StudentVeceducationInformationNavigation { get; set; }
}