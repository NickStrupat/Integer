internal interface IString<out T> : IString where T : IString<T>
{
	static abstract T Create(String value);
}

internal interface IString;