using FluentAssertions;
using Xunit;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.State.Test
{
    public class StatePatternTests
    {
        [Fact]
        public void ShouldHaveNewStateWhenCreate()
        {
            Context context = new Context();
            context.State.GetState().Should().BeEquivalentTo(State.New);
        }

        [Fact]
        public void ShouldMoveFromNewToInprogress()
        {
            Context context = new Context();
            context.Process();
            context.State.GetState().Should().BeEquivalentTo(State.InProgress);
        }

        [Fact]
        public void ShouldMoveFromInprogressToDone()
        {
            Context context = new Context();
            context.Process(); // In-Progress
            context.Process(); // Done
            context.State.GetState().Should().BeEquivalentTo(State.Done);
        }

        [Fact]
        public void ShouldUndoFromDoneToInprogress()
        {
            Context context = new Context();
            context.Process(); // In-Progress
            context.Process(); // Done
            context.Undo();

            context.State.GetState().Should().BeEquivalentTo(State.InProgress);
        }
    }
}
