using M31.FluentApi.Generator.CodeBuilding;
using M31.FluentApi.Generator.SourceGenerators.Generics;

namespace M31.FluentApi.Generator.CodeGeneration.CodeBoardElements;

internal sealed class MethodIdentity
{
    private MethodIdentity(
        string methodName,
        int numberOfTypeParameters,
        IReadOnlyCollection<ParameterIdentity> parameterIdentities)
    {
        MethodName = methodName;
        NumberOfTypeParameters = numberOfTypeParameters;
        ParameterIdentities = parameterIdentities;
    }

    internal string MethodName { get; }
    internal int NumberOfTypeParameters { get; }
    internal IReadOnlyCollection<ParameterIdentity> ParameterIdentities { get; }

    internal static MethodIdentity Create(string methodName) => new MethodIdentity(methodName, 0, Array.Empty<ParameterIdentity>());

    internal static MethodIdentity Create(MethodSymbolInfo methodSymbolInfo)
    {
        IReadOnlyCollection<ParameterIdentity> parameterIdentities = methodSymbolInfo.ParameterInfos
            .Select(i => ParameterIdentity.Create(
                i.TypeForCodeGeneration, i.GenericTypeParameterPosition, i.ParameterKinds))
            .ToArray();
        return Create(methodSymbolInfo.Name, methodSymbolInfo.GenericInfo, parameterIdentities);
    }

    internal static MethodIdentity Create(
        string methodName,
        GenericInfo? genericInfo,
        IReadOnlyCollection<Parameter> parameters)
    {
        IReadOnlyCollection<ParameterIdentity> parameterIdentities = parameters
            .Select(p => ParameterIdentity.Create(
                p.Type, p.GenericTypeParameterPosition, p.ParameterAnnotations?.ParameterKinds ?? ParameterKinds.None))
            .ToArray();
        return Create(methodName, genericInfo, parameterIdentities);
    }

    private static MethodIdentity Create(
        string methodName,
        GenericInfo? genericInfo,
        IReadOnlyCollection<ParameterIdentity> parameterIdentities)
    {
        int numberOfTypeParameters = genericInfo?.Parameters.Count ?? 0;
        return new MethodIdentity(methodName, numberOfTypeParameters, parameterIdentities);
    }

    internal bool Equals(MethodIdentity other)
        => MethodName == other.MethodName &&
               NumberOfTypeParameters == other.NumberOfTypeParameters &&
               ParameterIdentities.SequenceEqual(other.ParameterIdentities);

    public override bool Equals(object? obj)
        => obj is not null && (ReferenceEquals(this, obj) || (obj.GetType() == GetType() && Equals((MethodIdentity)obj)));

    public override int GetHashCode()
        => new HashCode()
            .Add(MethodName, NumberOfTypeParameters)
            .AddSequence(ParameterIdentities);

    public override string ToString() => $"{MethodName}<{NumberOfTypeParameters}>({string.Join(", ", ParameterIdentities)})";
}