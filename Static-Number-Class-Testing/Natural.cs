public sealed class Natural<D1> : INatural
where D1 : INaturalDigit
{
	private Natural() {}
	public static UInt64 Value { get; } = D1.Value;
	static Int64 IInteger.Value { get; } = (Int64) Value;
}

public sealed class Natural<D1, D2> : INatural
where D1 : INaturalDigit where D2 : INaturalDigit
{
	private Natural() {}
	public static UInt64 Value { get; } = INatural.Combine<D1, D2>();
	static Int64 IInteger.Value { get; } = (Int64) Value;
}

public sealed class Natural<D1, D2, D3> : INatural
where D1 : INaturalDigit where D2 : INaturalDigit where D3 : INaturalDigit
{
	private Natural() {}
	public static UInt64 Value { get; } = INatural.Combine<Natural<D1, D2>, D3>();
	static Int64 IInteger.Value { get; } = (Int64) Value;
}

public sealed class Natural<D1, D2, D3, D4> : INatural
where D1 : INaturalDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit
{
	private Natural() {}
	public static UInt64 Value { get; } = INatural.Combine<Natural<D1, D2, D3>, D4>();
	static Int64 IInteger.Value { get; } = (Int64) Value;
}

public sealed class Natural<D1, D2, D3, D4, D5> : INatural
where D1 : INaturalDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit
{
	private Natural() {}
	public static UInt64 Value { get; } = INatural.Combine<Natural<D1, D2, D3, D4>, D5>();
	static Int64 IInteger.Value { get; } = (Int64) Value;
}

public sealed class Natural<D1, D2, D3, D4, D5, D6> : INatural
where D1 : INaturalDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit
{
	private Natural() {}
	public static UInt64 Value { get; } = INatural.Combine<Natural<D1, D2, D3, D4, D5>, D6>();
	static Int64 IInteger.Value { get; } = (Int64) Value;
}

public sealed class Natural<D1, D2, D3, D4, D5, D6, D7> : INatural
where D1 : INaturalDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit where D7 : INaturalDigit
{
	private Natural() {}
	public static UInt64 Value { get; } = INatural.Combine<Natural<D1, D2, D3, D4, D5, D6>, D7>();
	static Int64 IInteger.Value { get; } = (Int64) Value;
}

public sealed class Natural<D1, D2, D3, D4, D5, D6, D7, D8> : INatural
where D1 : INaturalDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit where D7 : INaturalDigit where D8 : INaturalDigit
{
	private Natural() {}
	public static UInt64 Value { get; } = INatural.Combine<Natural<D1, D2, D3, D4, D5, D6, D7>, D8>();
	static Int64 IInteger.Value { get; } = (Int64) Value;
}

public sealed class Natural<D1, D2, D3, D4, D5, D6, D7, D8, D9> : INatural
where D1 : INaturalDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit where D7 : INaturalDigit where D8 : INaturalDigit where D9 : INaturalDigit
{
	private Natural() {}
	public static UInt64 Value { get; } = INatural.Combine<Natural<D1, D2, D3, D4, D5, D6, D7, D8>, D9>();
	static Int64 IInteger.Value { get; } = (Int64) Value;
}

public sealed class Natural<D1, D2, D3, D4, D5, D6, D7, D8, D9, D10> : INatural
where D1 : INaturalDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit where D7 : INaturalDigit where D8 : INaturalDigit where D9 : INaturalDigit where D10 : INaturalDigit
{
	private Natural() {}
	public static UInt64 Value { get; } = INatural.Combine<Natural<D1, D2, D3, D4, D5, D6, D7, D8, D9>, D10>();
	static Int64 IInteger.Value { get; } = (Int64) Value;
}

public sealed class Natural<D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11> : INatural
where D1 : INaturalDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit where D7 : INaturalDigit where D8 : INaturalDigit where D9 : INaturalDigit where D10 : INaturalDigit where D11 : INaturalDigit
{
	private Natural() {}
	public static UInt64 Value { get; } = INatural.Combine<Natural<D1, D2, D3, D4, D5, D6, D7, D8, D9, D10>, D11>();
	static Int64 IInteger.Value { get; } = (Int64) Value;
}

public sealed class Natural<D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12> : INatural
where D1 : INaturalDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit where D7 : INaturalDigit where D8 : INaturalDigit where D9 : INaturalDigit where D10 : INaturalDigit where D11 : INaturalDigit where D12 : INaturalDigit
{
	private Natural() {}
	public static UInt64 Value { get; } = INatural.Combine<Natural<D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11>, D12>();
	static Int64 IInteger.Value { get; } = (Int64) Value;
}
