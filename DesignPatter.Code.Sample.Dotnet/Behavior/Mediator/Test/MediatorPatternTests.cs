using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Mediator.Test
{
    public class MediatorPatternTests
    {
        [Fact]
        public void ShouldSendAndReceiveMessage()
        {
            Colleague mrA = new Colleague("Mr A");
            Colleague mrB = new Colleague("Mr B");

            Mediator mediator = new Mediator();
            string msg = "Hi, how are you doing";
            mediator.Send(mrA, mrB, msg);

            mrA.Message.Should().BeEquivalentTo($"Sent '{msg}' to {mrB.Name}");
            mrB.Message.Should().BeEquivalentTo($"Received '{msg}' from {mrA.Name}");
        }
    }
}
