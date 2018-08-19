using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Mediator
{
    public interface IColleague
    {
        string Message { get; }
        string Name { get; set; }

        void Receive(IColleague from, string msg);
        void Send(IColleague to, string msg);
    }
}
