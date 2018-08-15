using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Observer.Test
{
    public class ObserverPatternTests
    {
        [Fact]
        public void ShouldAttachNewObserver()
        {
            Observer observerA = new Observer();
            Subject subject = new Subject();
            subject.Attach(observerA);

            subject.Notify("observer A is attached");

            observerA.UpdateString.Should().BeEquivalentTo("observer A is attached");
        }

        [Fact]
        public void ShouldDettachExistingObserver()
        {
            Observer observerA = new Observer();
            Observer observerB = new Observer();
            Subject subject = new Subject();
            subject.Attach(observerA);
            subject.Attach(observerB);

            subject.Notify("observer B is attached");
            subject.Detach(observerA);
            subject.Notify("observer A is detached");

            observerB.UpdateString.Should().BeEquivalentTo("observer A is detached");
            observerA.UpdateString.Should().BeEquivalentTo("observer B is attached");
        }
    }
}
