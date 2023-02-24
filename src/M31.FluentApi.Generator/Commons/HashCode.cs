namespace M31.FluentApi.Generator.Commons;

internal struct HashCode
{
    private int hash;

    public HashCode()
    {
        hash = 17;
    }

    internal HashCode Add<T>(T value)
    {
        unchecked
        {
            hash = hash * 23 + value?.GetHashCode() ?? 0;
        }

        return this;
    }

    internal HashCode Add<T1, T2>(T1 value1, T2 value2)
    {
        unchecked
        {
            hash = hash * 23 + value1?.GetHashCode() ?? 0;
            hash = hash * 23 + value2?.GetHashCode() ?? 0;
        }

        return this;
    }

    internal HashCode Add<T1, T2, T3>(T1 value1, T2 value2, T3 value3)
    {
        unchecked
        {
            hash = hash * 23 + value1?.GetHashCode() ?? 0;
            hash = hash * 23 + value2?.GetHashCode() ?? 0;
            hash = hash * 23 + value3?.GetHashCode() ?? 0;
        }

        return this;
    }

    internal HashCode AddSequence<T>(IEnumerable<T> items)
    {
        unchecked
        {
            foreach (T item in items)
            {
                hash = hash * 23 + item?.GetHashCode() ?? 0;
            }

        }

        return this;
    }

    public static implicit operator int(HashCode hashCode) => hashCode.hash;
}