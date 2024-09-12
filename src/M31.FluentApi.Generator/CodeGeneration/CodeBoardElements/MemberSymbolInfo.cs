using M31.FluentApi.Generator.SourceGenerators.Collections;
using Microsoft.CodeAnalysis;

namespace M31.FluentApi.Generator.CodeGeneration.CodeBoardElements;

internal class MemberSymbolInfo : FluentApiSymbolInfo
{
    internal MemberSymbolInfo(
        string name,
        string type,
        Accessibility accessibility,
        bool requiresReflection,
        string typeForCodeGeneration,
        bool isNullable,
        bool isProperty,
        CollectionType? collectionType)
        : base(name, accessibility, requiresReflection)
    {
        Type = type;
        TypeForCodeGeneration = typeForCodeGeneration;
        IsNullable = isNullable;
        IsProperty = isProperty;
        CollectionType = collectionType;
    }

    internal string Type { get; }
    internal string TypeForCodeGeneration { get; }
    internal bool IsNullable { get; }
    internal bool IsProperty { get; }
    internal CollectionType? CollectionType { get; }

    protected bool Equals(MemberSymbolInfo other)
        => base.Equals(other) && Type == other.Type && TypeForCodeGeneration == other.TypeForCodeGeneration &&
               IsNullable == other.IsNullable && IsProperty == other.IsProperty &&
               Equals(CollectionType, other.CollectionType);

    public override bool Equals(object? obj) 
        => obj is not null && (ReferenceEquals(this, obj) || (obj.GetType() == GetType() && Equals((MemberSymbolInfo)obj)));

    public override int GetHashCode() 
        => new HashCode()
            .Add(base.GetHashCode(), Type, TypeForCodeGeneration)
            .Add(IsNullable, IsProperty)
            .Add(CollectionType);
}