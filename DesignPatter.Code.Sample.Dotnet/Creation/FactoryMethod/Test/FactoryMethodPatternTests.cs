using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatter.Code.Sample.Dotnet.Creation.FactoryMethod.Test
{
    public class FactoryMethodPatternTests
    {
        [Fact]
        public void ShouldReturnProductA()
        {
            IProduct product = Factory.GetProduct("A");

            product.Functionality().Should().BeEquivalentTo("Product A Functionality");
        }

        [Fact]
        public void ShouldReturnProductB()
        {
            IProduct product = Factory.GetProduct("B");

            product.Functionality().Should().BeEquivalentTo("Product B Functionality");
        }
    }
}
