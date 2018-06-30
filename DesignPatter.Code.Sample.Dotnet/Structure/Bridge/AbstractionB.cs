using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Bridge
{
    public class AbstractionB : IAbstraction
    {
        public override string Operation()
        {
            return "Operated by B. " + base.Operation();
        }
    }
}
