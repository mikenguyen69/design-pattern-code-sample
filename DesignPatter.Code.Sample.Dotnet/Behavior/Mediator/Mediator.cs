using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Mediator
{
    public class Mediator : IMediator
    {
        public void Send(IColleague from, IColleague to, string msg)
        {
            from.Send(to, msg);
            to.Receive(from, msg);
        }
    }
}
