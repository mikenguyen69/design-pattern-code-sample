using FluentAssertions;
using Xunit;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Decorator.Test
{
    public class DecoratorPatterTests
    {
        [Fact]
        public void ComponentShouldPerformWork()
        {
            IComponent comp = new Component("Common Part");
            comp.Operation().Should().BeEquivalentTo("Operated by Common Part.");
        }

        [Fact]
        public void AShouldPerformAdditionalPartAWork()
        {
            IComponent comp = new Component("Common Part");
            DecoratorBase A = new DecoratorA("Part A", comp);

            A.Operation().Should().StartWith("Operated by Part A");
            A.Operation().Should().EndWith("Operated by Common Part.");
        }

        [Fact]
        public void BShouldPerformAdditionalPartBWork()
        {
            IComponent comp = new Component("Common Part");
            DecoratorBase B = new DecoratorB("Part B", comp);

            B.Operation().Should().StartWith("Hmm Operated by Part B");
            B.Operation().Should().EndWith("Operated by Common Part.");
        }
    }
}
