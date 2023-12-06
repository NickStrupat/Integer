public abstract class OutOfRangeException : ArgumentOutOfRangeException
{
	internal OutOfRangeException(string value, string min, string max) :
		base($"Value must be between {min} and {max} inclusive, but was {value}") {}
}

public abstract class OutOfRangeException<T> : OutOfRangeException
where T : unmanaged
{
	public T Value { get; }
	public T Min { get; }
	public T Max { get; }

	internal OutOfRangeException(T value, T min, T max) :
		base($"{value}", $"{min}", $"{max}") =>
		(Value, Min, Max) = (value, min, max);
}

public sealed class UIntOutOfRangeException : OutOfRangeException<UInt64>
{
	internal UIntOutOfRangeException(UInt64 value, UInt64 min, UInt64 max) : base(value, min, max) {}
}

public sealed class IntOutOfRangeException : OutOfRangeException<Int64>
{
	internal IntOutOfRangeException(Int64 value, Int64 min, Int64 max) : base(value, min, max) {}
}
