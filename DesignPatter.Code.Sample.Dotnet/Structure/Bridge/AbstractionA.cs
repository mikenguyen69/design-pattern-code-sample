using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Bridge
{
    public class AbstractionA : IAbstraction
    {
        public override string Operation()
        {
            string opt = "Operated by A. ";
            opt += base.Operation();
            return opt ;
        }
    }
}
