﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class StudentVeceducationInformation
{
    public int Oid { get; set; }

    public int? Student { get; set; }

    public int? School { get; set; }

    public string? SchoolId { get; set; }

    public string? StudentId { get; set; }

    public string? Idcard { get; set; }

    public string? SchoolName { get; set; }

    public string? StudentCode { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? GroupAbbr { get; set; }

    public string? GradeNameTh { get; set; }

    public int? CertificateType { get; set; }

    public DateTime? EntranceDate { get; set; }

    public string? EntranceYear { get; set; }

    public string? EntranceSemester { get; set; }

    public string? GradeId { get; set; }

    public string? GraduateCode { get; set; }

    public int? Major { get; set; }

    public string? MajorId { get; set; }

    public string? MajorCode { get; set; }

    public string? MajorNameTh { get; set; }

    public int? Minor { get; set; }

    public string? MinorId { get; set; }

    public string? MinorCode { get; set; }

    public string? MinorNameTh { get; set; }

    public string? SubjectTypeCode { get; set; }

    public string? SubjectTypeId { get; set; }

    public string? SubjectTypeNameTh { get; set; }

    public string? Gpax { get; set; }

    public string? StudentStatusCode { get; set; }

    public string? StudentStatusName { get; set; }

    public string? StudentTypeCode { get; set; }

    public string? StudentTypeName { get; set; }

    public string? GradautedYearTh { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual CertificateType? CertificateTypeNavigation { get; set; }

    public virtual ICollection<GraduatedStudentJobTrackingReportStudentDetail> GraduatedStudentJobTrackingReportStudentDetails { get; set; } = new List<GraduatedStudentJobTrackingReportStudentDetail>();

    public virtual Major? MajorNavigation { get; set; }

    public virtual Minor? MinorNavigation { get; set; }

    public virtual School? SchoolNavigation { get; set; }

    public virtual Student? StudentNavigation { get; set; }
}