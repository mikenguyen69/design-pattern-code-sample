using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Strategy
{
    public class Context
    {
        public IList<IStrategy> Strategies = new List<IStrategy>();

        public void Process()
        {
            foreach(var s in Strategies)
            {
                s.Algorithm();
            }
        }
    }
}
