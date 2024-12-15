using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

public sealed class StringJsonConverter : JsonConverterFactory
{
	public override Boolean CanConvert(Type typeToConvert) => typeToConvert.GetInterfaces().Contains(typeof(IString));

	public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
	{
		return cache.GetOrAdd(typeToConvert, CreateJsonConverterFactory).Invoke();
		
		static Func<JsonConverter> CreateJsonConverterFactory(Type type)
		{
			var converterType = typeof(Converter<>).MakeGenericType(type);
			var lambda = Expression.Lambda(Expression.New(converterType));
			return (Func<JsonConverter>)lambda.Compile();
		}
	}
	
	private static readonly ConcurrentDictionary<Type, Func<JsonConverter>> cache = new();
	
	private class Converter<T> : JsonConverter<T> where T : IString<T>
	{
		public override Boolean HandleNull => false;
		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => T.Create(reader.GetString()!);
		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString());
	}
}