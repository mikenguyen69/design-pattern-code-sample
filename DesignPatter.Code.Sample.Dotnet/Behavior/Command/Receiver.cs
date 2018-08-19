using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Command
{
    public class Receiver : IReceiver
    {
        private CommandType command;
        public string Action()
        {
            return  $"Command {command} is executed.";
        }

        public string Undo()
        {
            return $"Command {command} is cancelled.";
        }

        public void SetAction(CommandType command)
        {
            this.command = command;
        }
    }
}
