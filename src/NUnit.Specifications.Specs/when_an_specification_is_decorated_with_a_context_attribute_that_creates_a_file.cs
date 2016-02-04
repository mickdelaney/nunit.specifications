using System.IO;
using NUnit.Framework;
using NUnit.Specifications.Specs.Attributes;
using Should;

namespace NUnit.Specifications.Specs
{
    // Used to manually validate that excluded categories don't get executed
    [CreateFile("touch.txt"), Category("exclude")]
    public class when_an_specification_is_decorated_with_a_context_attribute_that_creates_a_file : ContextSpecification
    {
        Cleanup after = () => File.Delete("touch.txt");

        It should_not_execute = () => File.Exists("touch.txt").ShouldBeTrue();
    }
}