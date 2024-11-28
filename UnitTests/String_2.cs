using FluentAssertions;

namespace UnitTests;

public class String_2
{
	public class Constructor
	{
		[TestCase<_1, _1>]
		[TestCase<_1, _2>]
		[TestCase<_2, _2>]
		public void WhenInstantiatedWithAMinLengthLessThanOrEqualToMaxLength_ShouldNotThrow<TMinLength, TMaxLength>() where TMinLength : INatural where TMaxLength : INatural
		{
			var stringOfMinLength = new String('a', (Int32)TMinLength.Value);
			var action = () => new String<TMinLength, TMaxLength>(stringOfMinLength);
			action.Should().NotThrow();
		}
		
		[TestCase<_2, _1>]
		public void WhenInstantiatedWithAMinLengthGreaterThanMaxLength_ShouldThrowArgumentOutOfRangeException<TMinLength, TMaxLength>() where TMinLength : INatural where TMaxLength : INatural
		{
			var action = () => new String<TMinLength, TMaxLength>("a");
			action.Should().ThrowExactly<ArgumentOutOfRangeException>().WithParameterName("TMaxLength");
		}
		
		[TestCase<_0, _0>]
		[TestCase<_0, _1>]
		[TestCase<_0, _2>]
		[TestCase<_1, _1>]
		[TestCase<_1, _2>]
		[TestCase<_2, _2>]
		public void WhenCalledWithNullArgument_ShouldThrowArgumentNullException<TMinLength, TMaxLength>() where TMinLength : INatural where TMaxLength : INatural
		{
			var action = () => new String<TMinLength, TMaxLength>(null!);
			action.Should().ThrowExactly<ArgumentNullException>();
		}
		
		[TestCase<_1, _1>]
		[TestCase<_1, _2>]
		[TestCase<_2, _2>]
		public void WhenCalledWithEmptyStringArgument_ShouldThrowArgumentOutOfRangeException<TMinLength, TMaxLength>() where TMinLength : INatural where TMaxLength : INatural
		{
			var action = () => new String<TMinLength, TMaxLength>(String.Empty);
			action.Should().ThrowExactly<ArgumentOutOfRangeException>().WithParameterName("value");
		}
	}
}