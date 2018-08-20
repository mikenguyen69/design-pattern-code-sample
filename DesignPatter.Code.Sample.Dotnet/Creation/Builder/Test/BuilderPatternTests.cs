using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatter.Code.Sample.Dotnet.Creation.Builder.Test
{
    public class BuilderPatternTests
    {
        [Fact]
        public void ShouldBuildAFerrari()
        {
            var builder = new FerrariBuilder();
            var director = new SportCarBuildDirector(builder);

            director.Construct();
            Car ferrari = builder.GetResult();

            ferrari.Color.Should().BeEquivalentTo("Red");
            ferrari.NumDoors.Should().Be(2);
            ferrari.Make.Should().BeEquivalentTo("Ferrari");
            ferrari.Model.Should().BeEquivalentTo("488 Spider");

        }
    }
}
