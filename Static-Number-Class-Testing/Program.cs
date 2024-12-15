using _10 = Natural<_1, _0>;
using _100 = Natural<_1, _0, _0>;
using _N42 = Integer<N4, _2>;
using _42 = Integer<_4, _2>;
using N623_256_804_006 = Integer<N6,_2,_3, _2,_5,_6, _8,_0,_4, _0,_0,_6>;
using _4_096 = (_4, _0,_9,_6);

Console.WriteLine($"{N623_256_804_006.Value:N0}");
Console.WriteLine(_N42.Value);
Console.WriteLine(_42.Value);
Console.WriteLine(Natural<_1, _9, _8, _6>.Value);
Console.WriteLine(new UInt<_10, _100>().Value);
Console.WriteLine(new UInt<_10, _100>().Value);
Console.WriteLine(new UInt<_10, _100>(11).Value);
Console.WriteLine(new UInt<_10, _100>(10).Value);
Console.WriteLine(new UInt<_10, _100>(99).Value);
Console.WriteLine(new UInt<_10, _100>(100).Value);

Console.WriteLine(new Int<_N42, _42>().Value);
Console.WriteLine(new Int<_N42, _42>(-42).Value);
Console.WriteLine(new Int<_N42, _42>(43).Value);

try
{
	Console.WriteLine(new UInt<_10, _100>(101).Value);
}
catch (UIntOutOfRangeException e)
{
	Console.WriteLine(e.Message);
}

try
{
	Console.WriteLine(new UInt<_10, _100>(9).Value);
}
catch (UIntOutOfRangeException e)
{
	Console.WriteLine(e.Message);
}

public interface IInt<T>
{
	T Value { get; }
	static abstract T Min { get; }
	static abstract T Max { get; }
}

public interface INatural : IInteger
{
	new static abstract UInt64 Value { get; }
	public new static UInt64 Combine<N1, N2>() where N1 : INatural where N2 : INaturalDigit => N1.Value * 10 + N2.Value;
}

public interface IInteger
{
	static abstract Int64 Value { get; }
	public static Int64 Combine<I1, I2>() where I1 : IInteger where I2 : IIntegerDigit => I1.Value * 10 + (I1.Value < 0 ? -I2.Value : I2.Value);
}

public interface INaturalDigit : IIntegerDigit, INatural;
public interface IIntegerDigit : IInteger;

public sealed class _0 : INaturalDigit { private _0() {} static Int64 IInteger.Value { get; } = 0; static UInt64 INatural.Value { get; } = 0; }
public sealed class _1 : INaturalDigit { private _1() {} static UInt64 INatural.Value { get; } = 1; static Int64 IInteger.Value { get; } = 1; }
public sealed class _2 : INaturalDigit { private _2() {} static UInt64 INatural.Value { get; } = 2; static Int64 IInteger.Value { get; } = 2; }
public sealed class _3 : INaturalDigit { private _3() {} static UInt64 INatural.Value { get; } = 3; static Int64 IInteger.Value { get; } = 3; }
public sealed class _4 : INaturalDigit { private _4() {} static UInt64 INatural.Value { get; } = 4; static Int64 IInteger.Value { get; } = 4; }
public sealed class _5 : INaturalDigit { private _5() {} static UInt64 INatural.Value { get; } = 5; static Int64 IInteger.Value { get; } = 5; }
public sealed class _6 : INaturalDigit { private _6() {} static UInt64 INatural.Value { get; } = 6; static Int64 IInteger.Value { get; } = 6; }
public sealed class _7 : INaturalDigit { private _7() {} static UInt64 INatural.Value { get; } = 7; static Int64 IInteger.Value { get; } = 7; }
public sealed class _8 : INaturalDigit { private _8() {} static UInt64 INatural.Value { get; } = 8; static Int64 IInteger.Value { get; } = 8; }
public sealed class _9 : INaturalDigit { private _9() {} static UInt64 INatural.Value { get; } = 9; static Int64 IInteger.Value { get; } = 9; }
public sealed class N9 : IIntegerDigit { private N9() {} static Int64 IInteger.Value { get; } = -9; }
public sealed class N8 : IIntegerDigit { private N8() {} static Int64 IInteger.Value { get; } = -8; }
public sealed class N7 : IIntegerDigit { private N7() {} static Int64 IInteger.Value { get; } = -7; }
public sealed class N6 : IIntegerDigit { private N6() {} static Int64 IInteger.Value { get; } = -6; }
public sealed class N5 : IIntegerDigit { private N5() {} static Int64 IInteger.Value { get; } = -5; }
public sealed class N4 : IIntegerDigit { private N4() {} static Int64 IInteger.Value { get; } = -4; }
public sealed class N3 : IIntegerDigit { private N3() {} static Int64 IInteger.Value { get; } = -3; }
public sealed class N2 : IIntegerDigit { private N2() {} static Int64 IInteger.Value { get; } = -2; }
public sealed class N1 : IIntegerDigit { private N1() {} static Int64 IInteger.Value { get; } = -1; }
