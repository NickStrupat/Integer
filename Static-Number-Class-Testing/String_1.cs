using System.Text.Json.Serialization;

[JsonConverter(typeof(StringJsonConverter))]
public sealed class String<TMinLength> : IString<String<TMinLength>>, IEquatable<String<TMinLength>> where TMinLength : INatural
{
	private readonly String value;

	public String(String value)
	{
		ArgumentNullException.ThrowIfNull(value);
		if ((UInt64)value.Length < TMinLength.Value)
			throw new StringLengthOutOfRangeException(value, TMinLength.Value, UInt64.MaxValue);
		this.value = value;
	}

	public Boolean Equals(String<TMinLength>? other) => other is not null && value == other.value;

	public override Boolean Equals(Object? obj) => obj is String<TMinLength> other && Equals(other);
	public override Int32 GetHashCode() => value.GetHashCode();

	public override String ToString() => value;
	
	public static implicit operator String(String<TMinLength> value) => value.value;
	public static explicit operator String<TMinLength>(String value) => new(value);
	
	public static Boolean operator ==(String<TMinLength>? left, String<TMinLength>? right) => Equals(left, right);
	public static Boolean operator !=(String<TMinLength>? left, String<TMinLength>? right) => !Equals(left, right);

	static String<TMinLength> IString<String<TMinLength>>.Create(String value) => new(value);
}