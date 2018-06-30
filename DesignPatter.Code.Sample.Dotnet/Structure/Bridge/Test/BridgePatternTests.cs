using FluentAssertions;
using Xunit;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Bridge.Test
{
    public class BridgePatternTests
    {
        [Fact]
        public void AShouldHaveImplementation1()
        {
            AbstractionA A = new AbstractionA();
            A.Bridge.Add(new Implementation1());
            A.Operation().Should().StartWith("Operated by A");
            A.Operation().Should().EndWith("Have implementation 1.");
        }

        [Fact]
        public void BShouldHaveBothImplemnetation()
        {
            AbstractionB B = new AbstractionB();
            B.Bridge.Add(new Implementation1());
            B.Bridge.Add(new Implementation2());
            B.Operation().Should().StartWith("Operated by B");
            B.Operation().Should().EndWith("Have implementation 1. Have implementation 2.");
        }
    }
}
