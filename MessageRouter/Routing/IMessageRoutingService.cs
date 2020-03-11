using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageRouter.Routing
{
    public interface IMessageRoutingService
    {
        void RouteEmail(Email email);
    }
}
