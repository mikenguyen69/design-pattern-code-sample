using FluentAssertions;
using Xunit;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Adapter.Test
{
    public class AdapterPatternTests
    {
        [Fact]
        public void AdapteeShouldDoOldOperation()
        {
            Adaptee adaptee = new Adaptee("OldCustomer");
            adaptee.SomeOperation().Should().BeEquivalentTo("OldCustomer performed some existing operation. ");
        }

        [Fact]
        public void AdapterShouldDoAdditionanNewOperation()
        {
            ITarget target = new Adapter("NewCustomer", new Adaptee("OldCustomer"));
            target.Operation().Should().StartWith("NewCustomer performed new operation. ");
            target.Operation().Should().EndWith("OldCustomer performed some existing operation. ");
        }
    }
}
