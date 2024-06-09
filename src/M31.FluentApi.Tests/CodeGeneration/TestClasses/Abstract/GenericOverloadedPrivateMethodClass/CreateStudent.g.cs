// <auto-generated/>
// This code was generated by the library M31.FluentAPI.
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#nullable enable

using System.Collections.Generic;
using M31.FluentApi.Attributes;
using System;
using System.Reflection;

namespace M31.FluentApi.Tests.CodeGeneration.TestClasses.Abstract.GenericOverloadedPrivateMethodClass;

public class CreateStudent :
    CreateStudent.ICreateStudent,
    CreateStudent.IMethod1Method1Method1Method1Method1Method1Method1
{
    private readonly Student student;
    private static readonly MethodInfo method1MethodInfo;
    private static readonly MethodInfo method1MethodInfo2;
    private static readonly MethodInfo method1MethodInfo3;
    private static readonly MethodInfo method1MethodInfo4;
    private static readonly MethodInfo method1MethodInfo5;
    private static readonly MethodInfo method1MethodInfo6;
    private static readonly MethodInfo method1MethodInfo7;

    static CreateStudent()
    {
        method1MethodInfo = typeof(Student).GetMethod(
            "Method1",
            0,
            BindingFlags.Instance | BindingFlags.NonPublic,
            null,
            new Type[] { typeof(int), typeof(string) },
            null)!;
        method1MethodInfo2 = typeof(Student).GetMethod(
            "Method1",
            1,
            BindingFlags.Instance | BindingFlags.NonPublic,
            null,
            new Type[] { typeof(int), typeof(string) },
            null)!;
        method1MethodInfo3 = typeof(Student).GetMethod(
            "Method1",
            1,
            BindingFlags.Instance | BindingFlags.NonPublic,
            null,
            new Type[] { Type.MakeGenericMethodParameter(0), typeof(string) },
            null)!;
        method1MethodInfo4 = typeof(Student).GetMethod(
            "Method1",
            2,
            BindingFlags.Instance | BindingFlags.NonPublic,
            null,
            new Type[] { Type.MakeGenericMethodParameter(1), typeof(string) },
            null)!;
        method1MethodInfo5 = typeof(Student).GetMethod(
            "Method1",
            2,
            BindingFlags.Instance | BindingFlags.NonPublic,
            null,
            new Type[] { Type.MakeGenericMethodParameter(1), typeof(string).MakeByRefType() },
            null)!;
        method1MethodInfo6 = typeof(Student).GetMethod(
            "Method1",
            2,
            BindingFlags.Instance | BindingFlags.NonPublic,
            null,
            new Type[] { Type.MakeGenericMethodParameter(1).MakeByRefType(), typeof(string) },
            null)!;
        method1MethodInfo7 = typeof(Student).GetMethod(
            "Method1",
            2,
            BindingFlags.Instance | BindingFlags.NonPublic,
            null,
            new Type[] { Type.MakeGenericMethodParameter(1).MakeByRefType(), typeof(string).MakeByRefType() },
            null)!;
    }

    private CreateStudent()
    {
        student = new Student();
    }

    public static ICreateStudent InitialStep()
    {
        return new CreateStudent();
    }

    public static Student Method1(int p1, string p2)
    {
        CreateStudent createStudent = new CreateStudent();
        CreateStudent.method1MethodInfo.Invoke(createStudent.student, new object?[] { p1, p2 });
        return createStudent.student;
    }

    public static Student Method1<T>(int p1, string p2)
    {
        CreateStudent createStudent = new CreateStudent();
        CreateStudent.method1MethodInfo2.MakeGenericMethod(typeof(T)).Invoke(createStudent.student, new object?[] { p1, p2 });
        return createStudent.student;
    }

    public static Student Method1<T>(T p1, string p2)
    {
        CreateStudent createStudent = new CreateStudent();
        CreateStudent.method1MethodInfo3.MakeGenericMethod(typeof(T)).Invoke(createStudent.student, new object?[] { p1, p2 });
        return createStudent.student;
    }

    public static Student Method1<S, T>(T p1, string p2)
    {
        CreateStudent createStudent = new CreateStudent();
        CreateStudent.method1MethodInfo4.MakeGenericMethod(typeof(S), typeof(T)).Invoke(createStudent.student, new object?[] { p1, p2 });
        return createStudent.student;
    }

    public static Student Method1<S, T>(T p1, out string p2)
    {
        CreateStudent createStudent = new CreateStudent();
        object?[] args = new object?[] { p1, null };
        CreateStudent.method1MethodInfo5.MakeGenericMethod(typeof(S), typeof(T)).Invoke(createStudent.student, args);
        p2 = (string) args[1]!;
        return createStudent.student;
    }

    public static Student Method1<S, T>(in T p1, string p2)
    {
        CreateStudent createStudent = new CreateStudent();
        CreateStudent.method1MethodInfo6.MakeGenericMethod(typeof(S), typeof(T)).Invoke(createStudent.student, new object?[] { p1, p2 });
        return createStudent.student;
    }

    public static Student Method1<S, T>(in T p1, ref string p2)
    {
        CreateStudent createStudent = new CreateStudent();
        object?[] args = new object?[] { p1, p2 };
        CreateStudent.method1MethodInfo7.MakeGenericMethod(typeof(S), typeof(T)).Invoke(createStudent.student, args);
        p2 = (string) args[1]!;
        return createStudent.student;
    }

    Student IMethod1Method1Method1Method1Method1Method1Method1.Method1(int p1, string p2)
    {
        CreateStudent.method1MethodInfo.Invoke(student, new object?[] { p1, p2 });
        return student;
    }

    Student IMethod1Method1Method1Method1Method1Method1Method1.Method1<T>(int p1, string p2)
    {
        CreateStudent.method1MethodInfo2.MakeGenericMethod(typeof(T)).Invoke(student, new object?[] { p1, p2 });
        return student;
    }

    Student IMethod1Method1Method1Method1Method1Method1Method1.Method1<T>(T p1, string p2)
    {
        CreateStudent.method1MethodInfo3.MakeGenericMethod(typeof(T)).Invoke(student, new object?[] { p1, p2 });
        return student;
    }

    Student IMethod1Method1Method1Method1Method1Method1Method1.Method1<S, T>(T p1, string p2)
    {
        CreateStudent.method1MethodInfo4.MakeGenericMethod(typeof(S), typeof(T)).Invoke(student, new object?[] { p1, p2 });
        return student;
    }

    Student IMethod1Method1Method1Method1Method1Method1Method1.Method1<S, T>(T p1, out string p2)
    {
        object?[] args = new object?[] { p1, null };
        CreateStudent.method1MethodInfo5.MakeGenericMethod(typeof(S), typeof(T)).Invoke(student, args);
        p2 = (string) args[1]!;
        return student;
    }

    Student IMethod1Method1Method1Method1Method1Method1Method1.Method1<S, T>(in T p1, string p2)
    {
        CreateStudent.method1MethodInfo6.MakeGenericMethod(typeof(S), typeof(T)).Invoke(student, new object?[] { p1, p2 });
        return student;
    }

    Student IMethod1Method1Method1Method1Method1Method1Method1.Method1<S, T>(in T p1, ref string p2)
    {
        object?[] args = new object?[] { p1, p2 };
        CreateStudent.method1MethodInfo7.MakeGenericMethod(typeof(S), typeof(T)).Invoke(student, args);
        p2 = (string) args[1]!;
        return student;
    }

    public interface ICreateStudent : IMethod1Method1Method1Method1Method1Method1Method1
    {
    }

    public interface IMethod1Method1Method1Method1Method1Method1Method1
    {
        Student Method1(int p1, string p2);

        Student Method1<T>(int p1, string p2);

        Student Method1<T>(T p1, string p2);

        Student Method1<S, T>(T p1, string p2);

        Student Method1<S, T>(T p1, out string p2);

        Student Method1<S, T>(in T p1, string p2);

        Student Method1<S, T>(in T p1, ref string p2);
    }
}