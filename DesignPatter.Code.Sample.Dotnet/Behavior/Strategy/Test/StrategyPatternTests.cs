using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Strategy.Test
{
    public class StrategyPatternTests
    {
        [Fact]
        public void ShouldExecuteDifferentStrategies()
        {
            StrategyA a = new StrategyA();
            StrategyB b = new StrategyB();

            Context context = new Context();
            context.Strategies.Add(a);
            context.Strategies.Add(b);

            context.Process();

            a.Message.Should().BeEquivalentTo("Algorithm A is being called.");
            b.Message.Should().BeEquivalentTo("Algorithm B is being called.");
        }
    }
}
