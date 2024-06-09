// <auto-generated/>
// This code was generated by the library M31.FluentAPI.
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#nullable enable

using M31.FluentApi.Attributes;

namespace M31.FluentApi.Tests.CodeGeneration.TestClasses.Abstract.PredicateClass;

public class CreateStudent :
    CreateStudent.ICreateStudent,
    CreateStudent.IWhoIsHappy
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

    public static Student WhoIsHappy(bool isHappy = true)
    {
        CreateStudent createStudent = new CreateStudent();
        createStudent.student.IsHappy = isHappy;
        return createStudent.student;
    }

    public static Student WhoIsSad()
    {
        CreateStudent createStudent = new CreateStudent();
        createStudent.student.IsHappy = false;
        return createStudent.student;
    }

    Student IWhoIsHappy.WhoIsHappy(bool isHappy)
    {
        student.IsHappy = isHappy;
        return student;
    }

    Student IWhoIsHappy.WhoIsSad()
    {
        student.IsHappy = false;
        return student;
    }

    public interface ICreateStudent : IWhoIsHappy
    {
    }

    public interface IWhoIsHappy
    {
        Student WhoIsHappy(bool isHappy = true);

        Student WhoIsSad();
    }
}