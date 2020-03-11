using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessageRouter.Validation
{
    public class EmailValidatorService : IEmailValidatorService
    {
        List<IValidationRule> _validationRules = new List<IValidationRule>();

        public EmailValidatorService()
        {
            _validationRules.Add(new HasValidSenderRule());
            _validationRules.Add(new IsReceiverUnsubscribedRule());
            _validationRules.Add(new IsMailBodyTextValidRule());
        }

        public bool ValidateEmail(Email email)
        {
            return _validationRules.All(rule => rule.Validate(email));
        }

    }
}
