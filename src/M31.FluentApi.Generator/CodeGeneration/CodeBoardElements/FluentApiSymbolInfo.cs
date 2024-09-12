using M31.FluentApi.Generator.Commons;
using Microsoft.CodeAnalysis;

namespace M31.FluentApi.Generator.CodeGeneration.CodeBoardElements;

internal abstract class FluentApiSymbolInfo
{
    internal FluentApiSymbolInfo(string name, Accessibility accessibility, bool requiresReflection)
    {
        Name = name;
        NameInCamelCase = Name.TrimStart('_').FirstCharToLower();
        Accessibility = accessibility;
        RequiresReflection = requiresReflection;
    }

    internal string Name { get; }
    internal string NameInCamelCase { get; }
    internal Accessibility Accessibility { get; }
    internal bool RequiresReflection { get; }

    protected bool Equals(FluentApiSymbolInfo other) 
        => Name == other.Name &&
               Accessibility == other.Accessibility &&
               RequiresReflection == other.RequiresReflection;

    public override bool Equals(object? obj)
        => obj is not null && (ReferenceEquals(this, obj) || (obj.GetType() == GetType() && Equals((FluentApiSymbolInfo)obj)));

    public override int GetHashCode() => new HashCode().Add(Name, Accessibility, RequiresReflection);
}