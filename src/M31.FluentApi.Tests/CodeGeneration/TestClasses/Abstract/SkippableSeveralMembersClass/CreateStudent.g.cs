// <auto-generated/>
// This code was generated by the library M31.FluentAPI.
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#nullable enable

using M31.FluentApi.Attributes;

namespace M31.FluentApi.Tests.CodeGeneration.TestClasses.Abstract.SkippableSeveralMembersClass;

public class CreateStudent :
    CreateStudent.ICreateStudent,
    CreateStudent.IWithMember1,
    CreateStudent.IWithMember2,
    CreateStudent.IWithMember3,
    CreateStudent.IWithMember4
{
    private readonly Student student;

    private CreateStudent()
    {
        student = new Student();
    }

    public static ICreateStudent InitialStep()
    {
        return new CreateStudent();
    }

    public static IWithMember2 WithMember1(string? member1)
    {
        CreateStudent createStudent = new CreateStudent();
        createStudent.student.Member1 = member1;
        return createStudent;
    }

    public static IWithMember3 WithMember2(string? member2)
    {
        CreateStudent createStudent = new CreateStudent();
        createStudent.student.Member2 = member2;
        return createStudent;
    }

    public static IWithMember4 WithMember3(string? member3)
    {
        CreateStudent createStudent = new CreateStudent();
        createStudent.student.Member3 = member3;
        return createStudent;
    }

    public static Student WithMember4(string member4)
    {
        CreateStudent createStudent = new CreateStudent();
        createStudent.student.Member4 = member4;
        return createStudent.student;
    }

    IWithMember2 IWithMember1.WithMember1(string? member1)
    {
        student.Member1 = member1;
        return this;
    }

    IWithMember3 IWithMember2.WithMember2(string? member2)
    {
        student.Member2 = member2;
        return this;
    }

    IWithMember4 IWithMember3.WithMember3(string? member3)
    {
        student.Member3 = member3;
        return this;
    }

    Student IWithMember4.WithMember4(string member4)
    {
        student.Member4 = member4;
        return student;
    }

    public interface ICreateStudent : IWithMember1
    {
    }

    public interface IWithMember1 : IWithMember2
    {
        IWithMember2 WithMember1(string? member1);
    }

    public interface IWithMember2 : IWithMember3
    {
        IWithMember3 WithMember2(string? member2);
    }

    public interface IWithMember3 : IWithMember4
    {
        IWithMember4 WithMember3(string? member3);
    }

    public interface IWithMember4
    {
        Student WithMember4(string member4);
    }
}