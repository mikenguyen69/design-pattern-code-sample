using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Facade
{
    public class SubSystemA
    {
        public object Operation1()
        {
            return OperationType.OperatedByA;
        }
    }
}
