using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageRouter.Validation
{
    public class IsReceiverUnsubscribedRule : IValidationRule
    {
        public bool Validate(Email email)
        {
            //logic to validate email 
            return true;
        }
    }
}
