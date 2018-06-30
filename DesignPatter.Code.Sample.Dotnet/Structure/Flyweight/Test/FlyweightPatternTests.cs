using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Flyweight.Test
{
    public class FlyweightPatternTests
    {
        [Fact]
        public void FlyweightShouldPerformOperation()
        {
            IFlyweight flyweight = new Flyweight("F1");

            flyweight.Operation().Should().BeEquivalentTo("Operated by F1");
        }
        
        [Fact]
        public void FlyweightShouldHaveStateFreeWhenCreated()
        {
            Flyweight flyweight = new Flyweight("F1");
            flyweight.State.Should().BeEquivalentTo("free");
        }

        [Fact]
        public void FlyweightShoulHaveStateUsedAfterTakingOperated()
        {
            Flyweight flyweight = new Flyweight("F1");
            flyweight.Operation();
            flyweight.State.Should().BeEquivalentTo("free");
        }        

        [Fact]
        public void FactoryShouldShouldReturnExistinInstanceHavingUsedState()
        {
            List<Flyweight> list = new List<Flyweight>()
            {
                new Flyweight("F1"),
                new Flyweight("F2")
            };

            FlyweightFactory factory = new FlyweightFactory(list);

            Flyweight instance = factory.GetFlyweight();

            instance.Should().NotBeNull();
            instance.State.Should().BeEquivalentTo("used");
        }
    }
}
