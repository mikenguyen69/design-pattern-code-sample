using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Command
{
    public enum CommandType
    {
        Cut,
        Copy,
        Paste,
        Delete
    }

    public class CutCommand : ACommand
    {
        public CutCommand(IReceiver receiver) : base(receiver)
        {
            receiver.SetAction(CommandType.Cut);
        }

        public override void Execute()
        {           
            message = receiver.Action();
        }

        public override void Undo()
        {
            message = receiver.Undo();
        }
    }

    public class DeleteCommand : ACommand
    {
        public DeleteCommand(IReceiver receiver) : base(receiver)
        {
            receiver.SetAction(CommandType.Delete);
        }

        public override void Execute()
        {
            message = receiver.Action();
        }

        public override void Undo()
        {
            message = receiver.Undo();
        }
    }
}
