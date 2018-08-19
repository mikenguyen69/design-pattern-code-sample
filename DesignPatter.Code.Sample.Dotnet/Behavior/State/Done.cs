using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.State
{
    public class Done : IState
    {
        public IState GetNext()
        {
            return null;
        }

        public IState GetPrevious()
        {
            return new InProgress();
        }

        public State GetState()
        {
            return State.Done;
        }
    }
}
