using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Command
{
    public abstract class ACommand
    {
        protected IReceiver receiver;
        protected string message = "";

        public ACommand(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public string Message { get { return Message; } }

        public abstract void Execute();
        public abstract void Undo();
    }
}
