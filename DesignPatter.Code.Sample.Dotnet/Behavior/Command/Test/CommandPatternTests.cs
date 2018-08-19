using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Command.Test
{
    public class CommandPatternTests
    {
        [Fact]
        public void ShouldInvokeCommand()
        {
            Invoker invoker = new Invoker();
            CutCommand cut = new CutCommand(new Receiver());
            invoker.Commands.Add(cut);

            invoker.Execute();

            cut.Message.Should().BeEquivalentTo("Command Cut is executed.");
        }
    }
}
