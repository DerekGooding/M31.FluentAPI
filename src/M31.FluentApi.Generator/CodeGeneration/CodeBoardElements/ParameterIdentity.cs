using M31.FluentApi.Generator.CodeBuilding;

namespace M31.FluentApi.Generator.CodeGeneration.CodeBoardElements;

internal sealed class ParameterIdentity
{
    private ParameterIdentity(string? nonGenericParameterType, int? genericTypeParameterPosition, bool hasModifier)
    {
        NonGenericParameterType = nonGenericParameterType;
        GenericTypeParameterPosition = genericTypeParameterPosition;
        HasModifier = hasModifier;
    }

    internal static ParameterIdentity Create(
        string parameterType,
        int? genericTypeParameterPosition,
        ParameterKinds parameterKinds)
    {
        bool isGeneric = genericTypeParameterPosition.HasValue;
        string? nonGenericParameterType = isGeneric ? null : parameterType;

        bool hasModifier = parameterKinds.HasFlag(ParameterKinds.In) ||
                           parameterKinds.HasFlag(ParameterKinds.Out) ||
                           parameterKinds.HasFlag(ParameterKinds.Ref);

        return new ParameterIdentity(nonGenericParameterType, genericTypeParameterPosition, hasModifier);
    }

    internal string? NonGenericParameterType { get; }
    internal int? GenericTypeParameterPosition { get; }
    internal bool HasModifier { get; }

    internal bool Equals(ParameterIdentity other) => NonGenericParameterType == other.NonGenericParameterType &&
               GenericTypeParameterPosition == other.GenericTypeParameterPosition &&
               HasModifier == other.HasModifier;

    public override bool Equals(object? obj) => obj is not null && (ReferenceEquals(this, obj) || (obj.GetType() == GetType() && Equals((ParameterIdentity)obj)));

    public override int GetHashCode() => new HashCode().Add(NonGenericParameterType, GenericTypeParameterPosition, HasModifier);

    public override string ToString()
    {
        string typeString = GenericTypeParameterPosition.HasValue
            ? $"g{GenericTypeParameterPosition.Value}"
            : NonGenericParameterType!;

        return HasModifier ? $"mod-{typeString}" : typeString;
    }
}