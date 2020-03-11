using MessageRouter.Validation;
using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageRouter.Routing
{
    public class TransactionalEmailRouter : EmailRouterBase
    {
        public TransactionalEmailRouter(Email email) : base(email, new EmailValidatorService())
        {
        }

        public override void SendEmail()
        {
            //call email sender implementation for transactional emails
            //or publish message to event bus
        }

    }
}
