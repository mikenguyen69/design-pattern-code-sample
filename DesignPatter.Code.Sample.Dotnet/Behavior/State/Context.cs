using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.State
{
    public class Context
    {
        public IState State;

        public Context()
        {
            State = new New();
        }

        public void Process()
        {
            State = State.GetNext();
        }

        public void Undo()
        {
            State = State.GetPrevious();
        }
    }
}
