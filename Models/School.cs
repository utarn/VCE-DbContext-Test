﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace TestVCE.Models;

public partial class School
{
    public int Oid { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public bool? IsActive { get; set; }

    public int? SchoolType { get; set; }

    public string? SchoolId { get; set; }

    public string? InstituteId { get; set; }

    public int? Institute { get; set; }

    public string? SchoolName { get; set; }

    public string? SchoolNameEn { get; set; }

    public string? Telephone { get; set; }

    public string? HouseNumber { get; set; }

    public string? VillageNumber { get; set; }

    public string? Trok { get; set; }

    public string? Soi { get; set; }

    public string? Street { get; set; }

    public string? TumbolCode { get; set; }

    public string? ZipCode { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public int? Tambon { get; set; }

    public DateTime? ImportDataDate { get; set; }

    public int? QuantityOfStudyingStudent { get; set; }

    public DateTime? LastUpdateDateQuantityOfStudyingStudent { get; set; }

    public int? OptimisticLockField { get; set; }

    public int? Gcrecord { get; set; }

    public DateTime? LastImportDate { get; set; }

    public bool? IsInImportingProcess { get; set; }

    public virtual ICollection<EmployerProfile> EmployerProfiles { get; set; } = new List<EmployerProfile>();

    public virtual ICollection<EmployerSchoolContact> EmployerSchoolContacts { get; set; } = new List<EmployerSchoolContact>();

    public virtual ICollection<GraduatedStudentJobTrackingReport> GraduatedStudentJobTrackingReports { get; set; } = new List<GraduatedStudentJobTrackingReport>();

    public virtual Institute? InstituteNavigation { get; set; }

    public virtual ICollection<SchoolEmployee> SchoolEmployees { get; set; } = new List<SchoolEmployee>();

    public virtual ICollection<SchoolGraduatedStudent> SchoolGraduatedStudents { get; set; } = new List<SchoolGraduatedStudent>();

    public virtual ICollection<StudentVeceducationInformation> StudentVeceducationInformations { get; set; } = new List<StudentVeceducationInformation>();

    public virtual Tambon? TambonNavigation { get; set; }
}