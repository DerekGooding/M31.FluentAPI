// <auto-generated/>
// This code was generated by the library M31.FluentAPI.
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.

#nullable enable

using System;
using M31.FluentApi.Attributes;

namespace M31.FluentApi.Tests.CodeGeneration.TestClasses.Abstract.TwoMemberClass;

public class CreateStudent : CreateStudent.IBornOn
{
    private readonly Student student;

    private CreateStudent()
    {
        student = new Student();
    }

    public static IBornOn WithName(string name)
    {
        CreateStudent createStudent = new CreateStudent();
        createStudent.student.Name = name;
        return createStudent;
    }

    public Student BornOn(System.DateOnly dateOfBirth)
    {
        student.DateOfBirth = dateOfBirth;
        return student;
    }

    public interface IBornOn
    {
        Student BornOn(System.DateOnly dateOfBirth);
    }
}