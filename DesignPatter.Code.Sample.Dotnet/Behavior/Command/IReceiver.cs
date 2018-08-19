using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Command
{
    public interface IReceiver
    {
        void SetAction(CommandType command);
        string Action();
        string Undo();
    }
}
