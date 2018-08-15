using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Observer
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string change)
        {
            foreach(var obs in _observers)
            {
                obs.Update(change);
            }
        }
    }
}
