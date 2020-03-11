using MessageRouter.Validation;
using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageRouter.Routing
{
    public class BatchEmailRouter : EmailRouterBase
    {
        public BatchEmailRouter(Email email) : base(email, new EmailValidatorService())
        {
        }

        public override void SendEmail()
        {
            //call email sender implementation for batch emails
            //or publish message to event bus
        }

    }
}
