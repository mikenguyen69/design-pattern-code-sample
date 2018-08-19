using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Command
{
    public class Invoker
    {
        public IList<ACommand> Commands = new List<ACommand>();

        public void Execute()
        {
            foreach (var c in Commands)
            {
                try
                {
                    c.Execute();
                }
                catch
                {
                    c.Undo();
                }
            }
        }
    }
}
