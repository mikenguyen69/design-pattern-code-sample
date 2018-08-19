using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Command.Test
{
    public class CommandPatternTests
    {
        Invoker invoker = new Invoker();
        [Fact]
        public void ShouldInvokeCommand()
        {
            CutCommand cut = new CutCommand(new Receiver());
            invoker.Commands.Add(cut);

            invoker.Execute();

            cut.Message.Should().BeEquivalentTo("Command Cut is executed.");
        }

        [Fact]
        public void DeleteCommandShouldCallUndo()
        {
            DeleteCommand delete = new DeleteCommand(new Receiver());
            invoker.Commands.Add(delete);

            invoker.Execute();

            delete.Message.Should().BeEquivalentTo("Command Delete is cancelled.");
        }

        [Fact]
        public void InvokeBothCommand()
        {
            CutCommand cut = new CutCommand(new Receiver());
            DeleteCommand delete = new DeleteCommand(new Receiver());

            invoker.Execute();

            cut.Message.Should().BeEquivalentTo("Command Cut is executed.");
            delete.Message.Should().BeEquivalentTo("Command Delete is cancelled.");
        }
    }
}
