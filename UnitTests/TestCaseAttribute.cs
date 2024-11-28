using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Builders;

namespace UnitTests;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TestCaseAttribute<T>(params Object?[]? arguments) : TestCaseBaseAttribute([typeof(T)], arguments);

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TestCaseAttribute<T1, T2>(params Object?[]? arguments) : TestCaseBaseAttribute([typeof(T1), typeof(T2)], arguments);

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TestCaseAttribute<T1, T2, T3>(params Object?[]? arguments) : TestCaseBaseAttribute([typeof(T1), typeof(T2), typeof(T3)], arguments);

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TestCaseAttribute<T1, T2, T3, T4>(params Object?[]? arguments) : TestCaseBaseAttribute([typeof(T1), typeof(T2), typeof(T3), typeof(T4)], arguments);

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TestCaseAttribute<T1, T2, T3, T4, T5>(params Object?[]? arguments) : TestCaseBaseAttribute([typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5)], arguments);

public abstract class TestCaseBaseAttribute(Type[] genericArguments, Object?[]? arguments) : TestCaseAttribute(arguments), ITestBuilder
{
	IEnumerable<TestMethod> ITestBuilder.BuildFrom(IMethodInfo method, Test? suite)
	{
		if (!method.IsGenericMethodDefinition)
			return base.BuildFrom(method, suite);

		var length = method.GetGenericArguments().Length;
		if (length != genericArguments.Length)
		{
			var @params = new TestCaseParameters { RunState = RunState.NotRunnable };
			@params.Properties.Set(PropertyNames.SkipReason, $"Method requires {genericArguments.Length} type arguments but TestCaseAttribute only supplied {length}");
			return [new NUnitTestCaseBuilder().BuildTestMethod(method, suite, @params)];
		}

		var genMethod = method.MakeGenericMethod(genericArguments);
		return base.BuildFrom(genMethod, suite);
	}
}