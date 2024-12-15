using System.Text.Json;
using FluentAssertions;

namespace UnitTests.JsonConverter;

public class String1
{
	[Test]
	public void Null()
	{
		var json = "null";
		var deserialized = JsonSerializer.Deserialize<String<_1>>(json);
		deserialized.Should().BeNull();
	}
	
	[Test]
	public void RoundTrip()
	{
		var str = new String<_1>("a");
		var json = JsonSerializer.Serialize(str);
		var deserialized = JsonSerializer.Deserialize<String<_1>>(json);
		deserialized.Should().Be(str);
	}
	
	[Test]
	public void DeserializeValidLength()
	{
		var json = """
		           "a"
		           """;
		var deserialized = JsonSerializer.Deserialize<String<_1>>(json);
		deserialized.Should().Be(new String<_1>("a"));
	}
	
	[Test]
	public void DeserializeInvalidLength()
	{
		var json = """
		           "ab"
		           """;
		Action action = () => JsonSerializer.Deserialize<String<_3>>(json);
		action.Should().Throw<ArgumentOutOfRangeException>();
	}
}
