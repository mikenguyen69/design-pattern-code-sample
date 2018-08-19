using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.State
{
    public class New : IState
    {
        public State GetState()
        {
            return State.New;
        }

        public IState GetNext()
        {
            return new InProgress();
        }

        public IState GetPrevious()
        {
            return null;
        }
    }
}
