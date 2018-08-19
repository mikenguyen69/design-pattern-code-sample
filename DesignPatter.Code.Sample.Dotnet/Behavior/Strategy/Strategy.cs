using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Strategy
{
    public class StrategyA : IStrategy
    {
        public string Message { get; private set; }

        public void Algorithm()
        {
            Message = $"Algorithm A is being called.";
        }
    }

    public class StrategyB : IStrategy
    {
        public string Message { get; private set; }

        public void Algorithm()
        {
            Message = $"Algorithm B is being called.";
        }
    }
}
