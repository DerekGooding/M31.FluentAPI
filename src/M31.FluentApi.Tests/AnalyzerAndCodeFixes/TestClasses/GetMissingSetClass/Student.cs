using M31.FluentApi.Attributes;

namespace M31.FluentApi.Tests.AnalyzerAndCodeFixes.TestClasses.GetMissingSetClass;

[FluentApi]
public class Student
{
    [FluentMember(0)]
    int Semester { get; }
}