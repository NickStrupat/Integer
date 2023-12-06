public readonly struct Int<TMin, TMax>(Int64 value) : IInt<Int64>
where TMin : IInteger
where TMax : IInteger
{
	private readonly Int64 value = value < TMin.Value | value > TMax.Value
		? throw new IntOutOfRangeException(value, TMin.Value, TMax.Value)
		: value - TMin.Value;
	public Int64 Value => value + TMin.Value;
	public override String ToString() => Value.ToString();
	public static Int64 Min { get; } = TMin.Value;
	public static Int64 Max { get; } = TMax.Value;
}
