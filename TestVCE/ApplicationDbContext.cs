using System.Reflection;

using Microsoft.EntityFrameworkCore;

using TestVCE.Models;

namespace TestVCE;

public class ApplicationDbContext : DbContext
{
    public DbSet<GraduatedStudentJobTrackingReportStudentDetail> GraduatedStudentJobTrackingReportStudentDetails =>
        Set<GraduatedStudentJobTrackingReportStudentDetail>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=5435;Database=VEC-Core-App-DB;Username=postgres;Password=password");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        builder.Entity<GraduatedStudentJobTrackingReportStudentDetail>(entity =>
        {
            entity.HasKey(e => e.Oid).HasName("GraduatedStudentJobTrackingReport_StudentDetail_pkey");

            entity.ToTable("GraduatedStudentJobTrackingReport_StudentDetail");

            entity.HasIndex(e => e.ContinuetoStudyLevel, "continuetostudy_index");

            entity.HasIndex(e => e.EmploymentStatus, "employmentstatus");

            entity.HasIndex(e => e.EmploymentStatus, "iEmploymentStatus_GraduatedStudentJobTrackingReport_St_DD3A9494");

            entity.HasIndex(e => e.Gcrecord, "iGCRecord_GraduatedStudentJobTrackingReport_StudentDetail");

            entity.HasIndex(e => e.GraduatedStudentJobTrackingReport,
                "iGraduatedStudentJobTrackingReport_GraduatedStudentJob_7B8D1A6B");

            entity.HasIndex(e => e.Student, "iStudent_GraduatedStudentJobTrackingReport_StudentDetail");

            entity.HasIndex(e => e.StudentVeceducationInformation,
                "iStudent_VECEducationInformation_GraduatedStudentJobTr_06E9A79F");

            entity.Property(e => e.Oid).HasColumnName("OID");
            entity.Property(e => e.ContinueToStudyInRelatedFieldStatusName).HasMaxLength(100);
            entity.Property(e => e.CorporationName).HasMaxLength(250);
            entity.Property(e => e.CorporationTaxId)
                .HasMaxLength(100)
                .HasColumnName("CorporationTaxID");
            entity.Property(e => e.EditDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.EmployerSummaryOid)
                .HasMaxLength(150)
                .HasColumnName("EmployerSummary_Oid");
            entity.Property(e => e.EmploymentStatusName).HasMaxLength(100);
            entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            entity.Property(e => e.GettingJobThatRelatedWithStudiedFieldStatusName).HasMaxLength(100);
            entity.Property(e => e.JobPositionCode).HasMaxLength(100);
            entity.Property(e => e.JobPositionName).HasMaxLength(250);
            entity.Property(e => e.Jobdescription)
                .HasMaxLength(120)
                .HasColumnName("jobdescription");
            entity.Property(e => e.Major)
                .HasMaxLength(120)
                .HasColumnName("major");
            entity.Property(e => e.Minor)
                .HasMaxLength(120)
                .HasColumnName("minor");
            entity.Property(e => e.OtherDescription).HasColumnName("Other_Description");
            entity.Property(e => e.SalaryRange).HasMaxLength(250);
            entity.Property(e => e.SchoolId).HasMaxLength(100);
            entity.Property(e => e.Semester).HasMaxLength(100);
            entity.Property(e => e.StudentVeceducationInformation).HasColumnName("Student_VECEducationInformation");
            entity.Property(e => e.StudyCourseTypeName).HasMaxLength(100);
            entity.Property(e => e.TrackingYearTh).HasMaxLength(4);
            entity.Property(e => e.UnknownRemark).HasColumnName("Unknown_Remark");

            // entity.HasOne(d => d.EmploymentStatusNavigation).WithMany(p => p.GraduatedStudentJobTrackingReportStudentDetails)
            //     .HasForeignKey(d => d.EmploymentStatus)
            //     .HasConstraintName("FK_GraduatedStudentJobTrackingReport_StudentDetail_Emp_C74373F0");
            //
            // entity.HasOne(d => d.GraduatedStudentJobTrackingReportNavigation).WithMany(p => p.GraduatedStudentJobTrackingReportStudentDetails)
            //     .HasForeignKey(d => d.GraduatedStudentJobTrackingReport)
            //     .HasConstraintName("FK_GraduatedStudentJobTrackingReport_StudentDetail_Gra_8F4F38ED");
            //
            // entity.HasOne(d => d.StudentNavigation).WithMany(p => p.GraduatedStudentJobTrackingReportStudentDetails)
            //     .HasForeignKey(d => d.Student)
            //     .HasConstraintName("FK_GraduatedStudentJobTrackingReport_StudentDetail_Student");
            //
            // entity.HasOne(d => d.StudentVeceducationInformationNavigation).WithMany(p => p.GraduatedStudentJobTrackingReportStudentDetails)
            //     .HasForeignKey(d => d.StudentVeceducationInformation)
            //     .HasConstraintName("FK_GraduatedStudentJobTrackingReport_StudentDetail_Stu_1393FDAE");
        });
        base.OnModelCreating(builder);
    }
}