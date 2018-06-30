using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Composite.Test
{
    public class CompositePatternTests
    {
        [Fact]
        public void ComponentShouldOperateByItSelf()
        {
            Component comp = new Component("Employee");
            comp.Operation().Should().BeEquivalentTo("Operated by Employee.");
        }

        [Fact]
        public void CompisiteShouldHaveItsefAndComponents()
        {
            List<IComponent> list = new List<IComponent>
            {
                new Component("EmployeeA"),
                new Component("EmployeeB")
            };

            IComponent composite = new Composite("Department1", list);

            composite.Operation().Should().StartWith("Operated by Department1.");
            composite.Operation().Should().EndWith("Operated by EmployeeA. Operated by EmployeeB.");
        }
    }
}

