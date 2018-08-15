using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Observer
{
    public class Observer : IObserver
    {
        private string _update;

        public string UpdateString
        {
            get { return _update; }
        }

        public void Update(string change)
        {
            _update = change;
        }
    }
}
