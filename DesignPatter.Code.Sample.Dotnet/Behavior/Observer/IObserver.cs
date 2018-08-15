using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Observer
{
    public interface IObserver
    {
        void Update(string change);
    }
}
