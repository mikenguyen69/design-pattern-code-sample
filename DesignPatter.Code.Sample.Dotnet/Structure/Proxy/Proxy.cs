using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Proxy
{
    public class Proxy : ITarget
    {
        private string name;
        private ITarget target;

        public Proxy(string name, ITarget target)
        {
            this.name = name;
            this.target = target;
        }

        public string Operation()
        {
            return $"{name} is redirecting. " + target.Operation();
        }
    }
}
