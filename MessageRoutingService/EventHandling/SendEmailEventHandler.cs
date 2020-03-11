using MessageRouter.Routing;
using Model.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MessageRoutingService.EventHandling
{
    public class SendEmailEventHandler
    {
        private IMessageRoutingService _messageRoutingService;

        public SendEmailEventHandler(IMessageRoutingService messageRoutingService)
        {
            _messageRoutingService = messageRoutingService;
        }

        //event bus handler mock for subscribed event SendEmail
        public async Task Handle(SendEmailEvent eventMessage)
        {
            _messageRoutingService.RouteEmail(eventMessage.Email);
        }

    }
}
