using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatter.Code.Sample.Dotnet.Behavior.Mediator
{
    public interface IMediator
    {
        void Send(IColleague from, IColleague to, string msg);
    }
}
