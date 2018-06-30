using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Structure.Decorator
{
    public class DecoratorBase : IComponent
    {
        private IComponent component;
        
        public DecoratorBase(IComponent component)
        {
            this.component = component;
        }

        public virtual string Operation()
        {
            return component.Operation();
        }
    }
}
