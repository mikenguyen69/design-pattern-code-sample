using FluentAssertions;
using Xunit;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Facade.Test
{    
    public class FacadePatternTests
    {        
        Facade facade = new Facade(new SubSystemA(), new SubsystemB(), new SubSystemC());

        [Fact]
        public void ShouldPerformOperationFromSystemA()
        {
            facade.Operation1().Should().Equals(OperationType.OperatedByA);
        }
        [Fact]
        public void ShouldPerformOperationFromSystemB()
        {
            facade.Operation2().Should().Equals(OperationType.OperatedByB);
        }
        [Fact]
        public void ShouldPerformOperationFromSystemC()
        {
            facade.Operation3().Should().Equals(OperationType.OperatedByC);
        }
    }
}
