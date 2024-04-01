// <auto-generated/>
// This code was generated by the library M31.FluentAPI.
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.

#nullable enable

using M31.FluentApi.Attributes;

namespace M31.FluentApi.Tests.CodeGeneration.TestClasses.Abstract.FluentMethodParameterModifiersClass;

public class CreateStudent : CreateStudent.IMethodWithRefParameter, CreateStudent.IMethodWithInParameter, CreateStudent.IMethodWithOutParameter, CreateStudent.IMethodWithRefInAndOutParameter
{
    private readonly Student student;

    private CreateStudent()
    {
        student = new Student();
    }

    public static IMethodWithRefParameter MethodWithParams(params int[] numbers)
    {
        CreateStudent createStudent = new CreateStudent();
        createStudent.student.MethodWithParams(numbers);
        return createStudent;
    }

    public IMethodWithInParameter MethodWithRefParameter(ref int n1)
    {
        student.MethodWithRefParameter(ref n1);
        return this;
    }

    public IMethodWithOutParameter MethodWithInParameter(in int n2)
    {
        student.MethodWithInParameter(in n2);
        return this;
    }

    public IMethodWithRefInAndOutParameter MethodWithOutParameter(out int n3)
    {
        student.MethodWithOutParameter(out n3);
        return this;
    }

    public Student MethodWithRefInAndOutParameter(ref int n4, in int n5, out int n6)
    {
        student.MethodWithRefInAndOutParameter(ref n4, in n5, out n6);
        return student;
    }

    public interface IMethodWithRefParameter
    {
        IMethodWithInParameter MethodWithRefParameter(ref int n1);
    }

    public interface IMethodWithInParameter
    {
        IMethodWithOutParameter MethodWithInParameter(in int n2);
    }

    public interface IMethodWithOutParameter
    {
        IMethodWithRefInAndOutParameter MethodWithOutParameter(out int n3);
    }

    public interface IMethodWithRefInAndOutParameter
    {
        Student MethodWithRefInAndOutParameter(ref int n4, in int n5, out int n6);
    }
}