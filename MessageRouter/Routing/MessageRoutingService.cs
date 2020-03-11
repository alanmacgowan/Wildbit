using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageRouter.Routing
{
    public class MessageRoutingService : IMessageRoutingService
    {

        public void RouteEmail(Email email) 
        {
            var emailRouter = EmailRouterFactory.GetInstance(email);
            if (emailRouter.ValidateEmail())
            {
                emailRouter.SendEmail();
            }
            else
            {
                //save details in db
                //and publish message to event bus
            }
        }

    }
}
