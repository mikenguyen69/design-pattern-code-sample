using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Decorator
{
    public class DecoratorA : DecoratorBase
    {
        private string name;

        public DecoratorA(string name, IComponent component) : 
            base(component)
        {
            this.name = name;
        }

        public override string Operation()
        {
            return $"Operated by {name}" + base.Operation();
        }
    }
}
