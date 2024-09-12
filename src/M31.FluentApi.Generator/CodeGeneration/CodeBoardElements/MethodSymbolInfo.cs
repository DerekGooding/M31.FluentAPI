using M31.FluentApi.Generator.SourceGenerators.Generics;
using Microsoft.CodeAnalysis;

namespace M31.FluentApi.Generator.CodeGeneration.CodeBoardElements;

internal class MethodSymbolInfo : FluentApiSymbolInfo
{
    internal MethodSymbolInfo(
        string name,
        Accessibility accessibility,
        bool requiresReflection,
        GenericInfo? genericInfo,
        IReadOnlyCollection<ParameterSymbolInfo> parameterInfos,
        string returnType)
        : base(name, accessibility, requiresReflection)
    {
        GenericInfo = genericInfo;
        ParameterInfos = parameterInfos;
        ReturnType = returnType;
    }

    internal GenericInfo? GenericInfo { get; }
    internal IReadOnlyCollection<ParameterSymbolInfo> ParameterInfos { get; }
    internal string ReturnType { get; }

    protected bool Equals(MethodSymbolInfo other)
        => base.Equals(other) &&
               Equals(GenericInfo, other.GenericInfo) &&
               ParameterInfos.SequenceEqual(other.ParameterInfos) &&
               ReturnType == other.ReturnType;

    public override bool Equals(object? obj)
        => obj is not null && (ReferenceEquals(this, obj) || (obj.GetType() == GetType() && Equals((MethodSymbolInfo)obj)));

    public override int GetHashCode()
        => new HashCode()
            .Add(base.GetHashCode())
            .Add(GenericInfo)
            .AddSequence(ParameterInfos)
            .Add(ReturnType);
}