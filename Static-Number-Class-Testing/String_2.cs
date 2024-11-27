public sealed class String<TMinLength, TMaxLength>(String value) : IEquatable<String<TMinLength, TMaxLength>> where TMinLength : INatural where TMaxLength : INatural
{
	private readonly String value = value switch
	{
		null => throw new ArgumentNullException(nameof(value)),
		_ when (UInt64)value.Length < TMinLength.Value => throw new ArgumentOutOfRangeException(nameof(value)),
		_ when (UInt64)value.Length > TMaxLength.Value => throw new ArgumentOutOfRangeException(nameof(value)),
		_ => value
	};

	public Boolean Equals(String<TMinLength, TMaxLength>? other) => other is not null && value == other.value;
	public override Boolean Equals(Object? obj) => obj is String<TMinLength, TMaxLength> other && Equals(other);
	public override Int32 GetHashCode() => value.GetHashCode();

	public override String ToString() => value;
	
	public static implicit operator String(String<TMinLength, TMaxLength> value) => value.value;
	public static explicit operator String<TMinLength, TMaxLength>(String value) => new(value);
	
	public static Boolean operator ==(String<TMinLength, TMaxLength>? left, String<TMinLength, TMaxLength>? right) => Equals(left, right);
	public static Boolean operator !=(String<TMinLength, TMaxLength>? left, String<TMinLength, TMaxLength>? right) => !Equals(left, right);
}