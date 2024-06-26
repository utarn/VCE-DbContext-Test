﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class JobPosting
{
    public int Oid { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? DeletedDate { get; set; }

    public int? EmployerProfile { get; set; }

    public string? JobPostingId { get; set; }

    public int? JobSegment { get; set; }

    public int? EmploymentCategory { get; set; }

    public bool? IsArgent { get; set; }

    public bool? IsOtherJobSegment { get; set; }

    public string? OtherJobSegmentName { get; set; }

    public string? PositionName { get; set; }

    public string? JobDescription { get; set; }

    public string? WorkingTimeStart { get; set; }

    public string? WorkingTimeEnd { get; set; }

    public int? Unit { get; set; }

    public bool? IsNotSpecifiedUnit { get; set; }

    public decimal? MinimumWage { get; set; }

    public decimal? MaximumWage { get; set; }

    public int? PayRate { get; set; }

    public bool? NotSpecifiedWage { get; set; }

    public string? WorkingPlaceAddress { get; set; }

    public int? WorkingPlaceProvince { get; set; }

    public int? WorkingPlaceDistrict { get; set; }

    public int? WorkingPlaceTambon { get; set; }

    public int? ApplicantRequiredGenderChoice { get; set; }

    public int? ApplicantRequiredCertificateType { get; set; }

    public bool? NoRequireCertificate { get; set; }

    public string? ApplicantSpecification { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? CoordinatorFullName { get; set; }

    public string? CoordinatorPhoneNo { get; set; }

    public string? CoordinatorEmail { get; set; }

    public int? JobPostingStatus { get; set; }

    public DateTime? JobPostingStatusUpdatedDate { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public virtual CertificateType? ApplicantRequiredCertificateTypeNavigation { get; set; }

    public virtual EmployerProfile? EmployerProfileNavigation { get; set; }

    public virtual EmploymentCategory? EmploymentCategoryNavigation { get; set; }

    public virtual ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();

    public virtual EntityStatus? JobPostingStatusNavigation { get; set; }

    public virtual JobSegment? JobSegmentNavigation { get; set; }

    public virtual PayRate? PayRateNavigation { get; set; }

    public virtual District? WorkingPlaceDistrictNavigation { get; set; }

    public virtual Province? WorkingPlaceProvinceNavigation { get; set; }

    public virtual Tambon? WorkingPlaceTambonNavigation { get; set; }
}