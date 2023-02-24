// <auto-generated/>
// This code was generated by the library M31.FluentAPI.
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.

#nullable enable

using M31.FluentApi.Attributes;
using System.Collections.Generic;

namespace M31.FluentApi.Tests.CodeGeneration.TestClasses.Abstract.FullyQualifiedTypeClass;

public class CreateStudent
{
    private readonly Student student;

    private CreateStudent()
    {
        student = new Student();
    }

    public static Student BornOn(System.DateOnly dateOfBirth)
    {
        CreateStudent createStudent = new CreateStudent();
        createStudent.student.DateOfBirth = dateOfBirth;
        return createStudent.student;
    }

    public static Student WithFriends(System.Collections.Generic.List<string> friends)
    {
        CreateStudent createStudent = new CreateStudent();
        createStudent.student.Friends = friends;
        return createStudent.student;
    }

    public static Student WithFriends(params string[] friends)
    {
        CreateStudent createStudent = new CreateStudent();
        createStudent.student.Friends = new List<string>(friends);
        return createStudent.student;
    }

    public static Student WithFriend(string friend)
    {
        CreateStudent createStudent = new CreateStudent();
        createStudent.student.Friends = new List<string>(1){ friend };
        return createStudent.student;
    }

    public static Student WithZeroFriends()
    {
        CreateStudent createStudent = new CreateStudent();
        createStudent.student.Friends = new List<string>(0);
        return createStudent.student;
    }
}