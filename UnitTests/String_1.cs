using FluentAssertions;

namespace UnitTests;
using _100 = Natural<_1,_0,_0>;

public class String_1
{
	public class Constructor
	{
		[TestCase<_0>]
		[TestCase<_1>]
		[TestCase<_2>]
		public void WhenCalledWithNullArgument_ShouldThrowArgumentNullException<T>() where T : INatural
		{
			var action = () => new String<T>(null!);
			
			action.Should().ThrowExactly<ArgumentNullException>();
		}
		
		[Test]
		public void WhenCalledWithEmptyStringArgument_ShouldThrowArgumentOutOfRangeException()
		{
			var action = () => new String<_1>(String.Empty);
			
			action.Should().ThrowExactly<StringLengthOutOfRangeException>()
				.Where(x => x.Min == 1)
				.Where(x => x.Max == UInt64.MaxValue)
				.Where(x => x.Value == 0)
				;
		}
		
		[Test]
		public void Test1()
		{
			var action = () => new String<_1>("a");
			
			action.Should().NotThrow();
		}
	}
}