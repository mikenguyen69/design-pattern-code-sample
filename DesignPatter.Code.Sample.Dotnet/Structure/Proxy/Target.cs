using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Proxy
{
    public class Target : ITarget
    {
        private string name;

        public Target(string name)
        {
            this.name = name;
        }

        public string Operation()
        {
            return $"{name} performed the work.";
        }
    }
}
