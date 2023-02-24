// Non-nullable member is uninitialized

#pragma warning disable CS8618

using M31.FluentApi.Attributes;

namespace M31.FluentApi.Tests.CodeGeneration.TestClasses.Abstract.FluentNullableNoNullableAnnotationPrivateSetClass;

[FluentApi]
public class Student
{
    [FluentMember(0, "WithName")]
    [FluentNullable("WhoseNameIsUnknown")]
    public string Name { get; private set; }
}