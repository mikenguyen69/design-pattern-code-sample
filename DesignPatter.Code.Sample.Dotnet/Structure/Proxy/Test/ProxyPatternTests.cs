using FluentAssertions;
using Xunit;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Proxy.Test
{
    public class ProxyPatternTests
    {
        [Fact]
        public void TargetShouldPerformWork()
        {
            ITarget target = new Target("Customer");
            target.Operation().Should().BeEquivalentTo("Customer performed the work.");
        }

        [Fact]
        public void ProxyShouldPerformTargetWork()
        {
            ITarget proxy = new Proxy("CustomerProxy", new Target("Customer"));
            proxy.Operation().Should().StartWith("CustomerProxy is redirecting.");
            proxy.Operation().Should().EndWith("Customer performed the work.");
        }
    }
}
