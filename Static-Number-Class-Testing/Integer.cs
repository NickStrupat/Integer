public sealed class Integer<D> : IInteger
where D : IIntegerDigit
{
	private Integer() {}
	public static Int64 Value { get; } = D.Value;
}

public sealed class Integer<D1, D2> : IInteger
where D1 : IIntegerDigit where D2 : INaturalDigit
{
	private Integer() {}
	public static Int64 Value { get; } = IInteger.Combine<D1, D2>();
}

public sealed class Integer<D1, D2, D3> : IInteger
where D1 : IIntegerDigit where D2 : INaturalDigit where D3 : INaturalDigit
{
	private Integer() {}
	public static Int64 Value { get; } = IInteger.Combine<Integer<D1, D2>, D3>();
}

public sealed class Integer<D1, D2, D3, D4> : IInteger
where D1 : IIntegerDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit
{
	private Integer() {}
	public static Int64 Value { get; } = IInteger.Combine<Integer<D1, D2, D3>, D4>();
}

public sealed class Integer<D1, D2, D3, D4, D5> : IInteger
where D1 : IIntegerDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit
{
	private Integer() {}
	public static Int64 Value { get; } = IInteger.Combine<Integer<D1, D2, D3, D4>, D5>();
}

public sealed class Integer<D1, D2, D3, D4, D5, D6> : IInteger
where D1 : IIntegerDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit
{
	private Integer() {}
	public static Int64 Value { get; } = IInteger.Combine<Integer<D1, D2, D3, D4, D5>, D6>();
}

public sealed class Integer<D1, D2, D3, D4, D5, D6, D7> : IInteger
where D1 : IIntegerDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit where D7 : INaturalDigit
{
	private Integer() {}
	public static Int64 Value { get; } = IInteger.Combine<Integer<D1, D2, D3, D4, D5, D6>, D7>();
}

public sealed class Integer<D1, D2, D3, D4, D5, D6, D7, D8> : IInteger
where D1 : IIntegerDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit where D7 : INaturalDigit where D8 : INaturalDigit
{
	private Integer() {}
	public static Int64 Value { get; } = IInteger.Combine<Integer<D1, D2, D3, D4, D5, D6, D7>, D8>();
}

public sealed class Integer<D1, D2, D3, D4, D5, D6, D7, D8, D9> : IInteger
where D1 : IIntegerDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit where D7 : INaturalDigit where D8 : INaturalDigit where D9 : INaturalDigit
{
	private Integer() {}
	public static Int64 Value { get; } = IInteger.Combine<Integer<D1, D2, D3, D4, D5, D6, D7, D8>, D9>();
}

public sealed class Integer<D1, D2, D3, D4, D5, D6, D7, D8, D9, D10> : IInteger
where D1 : IIntegerDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit where D7 : INaturalDigit where D8 : INaturalDigit where D9 : INaturalDigit where D10 : INaturalDigit
{
	private Integer() {}
	public static Int64 Value { get; } = IInteger.Combine<Integer<D1, D2, D3, D4, D5, D6, D7, D8, D9>, D10>();
}

public sealed class Integer<D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11> : IInteger
where D1 : IIntegerDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit where D7 : INaturalDigit where D8 : INaturalDigit where D9 : INaturalDigit where D10 : INaturalDigit where D11 : INaturalDigit
{
	private Integer() {}
	public static Int64 Value { get; } = IInteger.Combine<Integer<D1, D2, D3, D4, D5, D6, D7, D8, D9, D10>, D11>();
}

public sealed class Integer<D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12> : IInteger
where D1 : IIntegerDigit where D2 : INaturalDigit where D3 : INaturalDigit where D4 : INaturalDigit where D5 : INaturalDigit where D6 : INaturalDigit where D7 : INaturalDigit where D8 : INaturalDigit where D9 : INaturalDigit where D10 : INaturalDigit where D11 : INaturalDigit where D12 : INaturalDigit
{
	private Integer() {}
	public static Int64 Value { get; } = IInteger.Combine<Integer<D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11>, D12>();
}
