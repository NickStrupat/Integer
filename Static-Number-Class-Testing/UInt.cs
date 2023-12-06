public readonly struct UInt<TMax>(UInt64 value) : IInt<UInt64>
where TMax : INatural
{
	public UInt64 Value { get; } = value <= TMax.Value ? value : throw new UIntOutOfRangeException(value, 0, TMax.Value);
	public override String ToString() => Value.ToString();
	public static UInt64 Min { get; } = 0;
	public static UInt64 Max { get; } = TMax.Value;
}

public readonly struct UInt<TMin, TMax>(UInt64 value) : IInt<UInt64>
where TMin : INatural
where TMax : INatural
{
	private readonly UInt64 value = value < TMin.Value | value > TMax.Value
		? throw new UIntOutOfRangeException(value, TMin.Value, TMax.Value)
		: value - TMin.Value;
	public UInt64 Value => value + TMin.Value;
	public override String ToString() => Value.ToString();
	public static UInt64 Min { get; } = TMin.Value;
	public static UInt64 Max { get; } = TMax.Value;
}
