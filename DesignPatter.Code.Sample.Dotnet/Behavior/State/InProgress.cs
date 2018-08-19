using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.State
{
    public class InProgress : IState
    {
        public IState GetNext()
        {
            return new Done();
        }

        public IState GetPrevious()
        {
            return new New();
        }

        public State GetState()
        {
            return State.InProgress;
        }
    }
}
