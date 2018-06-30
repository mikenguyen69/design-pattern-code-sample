using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Decorator
{
    public class DecoratorB : DecoratorBase
    {
        private string name;

        public DecoratorB(string name, IComponent component) : 
            base(component)
        {
            this.name = name;
        }

        public override string Operation()
        {
            return $"Hmm Operated by {name}" + base.Operation();
        }
    }
}
