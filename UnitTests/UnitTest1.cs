using FluentAssertions;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Builders;

namespace UnitTests;
using _100 = Natural<_1,_0,_0>;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TestCaseAttribute<T>(params Object?[]? arguments) : TestCaseAttribute(arguments), ITestBuilder
{
	IEnumerable<TestMethod> ITestBuilder.BuildFrom(IMethodInfo method, Test? suite)
	{
		if (!method.IsGenericMethodDefinition)
			return base.BuildFrom(method, suite);

		var length = method.GetGenericArguments().Length;
		if (length != 1)
		{
			var @params = new TestCaseParameters { RunState = RunState.NotRunnable };
			@params.Properties.Set(PropertyNames.SkipReason, $"Method has {length} type parameters, but only 1 type argument was provided.");
			return [new NUnitTestCaseBuilder().BuildTestMethod(method, suite, @params)];
		}

		var genMethod = method.MakeGenericMethod(typeof(T));
		return base.BuildFrom(genMethod, suite);
	}
}

public class String_1
{
	public class Constructor
	{
		[TestCase<_0>]
		[TestCase<_1>]
		[TestCase<_2>]
		public void WhenCalledWithNullStringArgument_ShouldThrowArgumentNullException<T>() where T : INatural
		{
			var action = () => new String<T>(null!);
			action.Should().ThrowExactly<ArgumentNullException>();
		}
		
		[Test]
		public void WhenCalledWithEmptyStringArgument_ShouldThrowArgumentOutOfRangeException()
		{
			var action = () => new String<_1>("");
			action.Should().ThrowExactly<ArgumentOutOfRangeException>();
		}
		
		[Test]
		public void Test1()
		{
			var action = () => new String<_1>("a");
			action.Should().NotThrow();
		}
	}
}