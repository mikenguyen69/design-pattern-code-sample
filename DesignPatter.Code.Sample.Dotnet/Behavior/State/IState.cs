using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.State
{
    public enum State
    {
        New,
        InProgress,
        Done
    }

    public interface IState
    {
        IState GetPrevious();
        IState GetNext();
        State GetState();
    }
}
