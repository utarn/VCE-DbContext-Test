// See https://aka.ms/new-console-template for more information


using TestVCE;

using var dbContext = new ApplicationDbContext();

// measure time to get all students
var watch = System.Diagnostics.Stopwatch.StartNew();

var students = dbContext.GraduatedStudentJobTrackingReportStudentDetails.ToList();

// students count group by EmploymentStatusName
var studentsGroupByEmploymentStatusName = students
    .GroupBy(x => x.EmploymentStatusName)
    .Select(x => new { EmploymentStatusName = x.Key, Count = x.Count() })
    .ToList();
watch.Stop();
var elapsedMs = watch.ElapsedMilliseconds;
Console.WriteLine($"Time to get all students: {elapsedMs} ms");


// measure time to get all students
watch.Restart();

var studentsQuery = dbContext.GraduatedStudentJobTrackingReportStudentDetails.AsQueryable();

// students count group by EmploymentStatusName
var studentsGroupByEmploymentStatusNameQuery = studentsQuery
    .GroupBy(x => x.EmploymentStatusName)
    .Select(x => new { EmploymentStatusName = x.Key, Count = x.Count() })
    .ToList();
watch.Stop();
var elapsedMs2 = watch.ElapsedMilliseconds;
Console.WriteLine($"Time to get all students: {elapsedMs2} ms");
