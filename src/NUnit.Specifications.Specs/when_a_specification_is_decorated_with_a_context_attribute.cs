using System;
using System.Dynamic;
using System.Linq.Expressions;
using NUnit.Specifications.Specs.Attributes;
using Should;

namespace NUnit.Specifications.Specs
{
	[Initializable]
	public class when_a_specification_is_decorated_with_a_context_attribute : ContextSpecification
	{
		It should_initialize_the_attribute = () => ((bool) Context.IsInitialized).ShouldBeTrue();

		It should_initialize_the_attribute_only_once = () => ((int) Context.InitializeCount).ShouldEqual(1);
	}


    [Initializable]
    public class when_a_test_runs_it_should_call_each_block : ContextSpecification
    {
        Establish context = () =>
        {
            Console.WriteLine("Establish...");
        };

        Because of = () =>
        {
            Console.WriteLine("Because...");
        };

        It should_initialize_the_attribute = () => ((bool)Context.IsInitialized).ShouldBeTrue();

        It should_initialize_the_attribute_only_once = () => ((int)Context.InitializeCount).ShouldEqual(1);
    }
}