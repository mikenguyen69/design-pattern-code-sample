using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Mediator
{
    public class Colleague : IColleague
    {
        protected string message;
        protected string name;

        public string Message { get { return message; } }
        public string Name { get; set; }

        public Colleague(string name)
        {
            this.name = name;
        }

        public void Receive(IColleague from, string msg)
        {
            message = $"Received '{msg}' from {from.Name}";
        }

        public void Send(IColleague to, string msg)
        {
            message = $"Sent '{msg}' to {to.Name}";
        }
    }
}
