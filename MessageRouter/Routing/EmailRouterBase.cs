using MessageRouter.Validation;
using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageRouter.Routing
{
    public abstract class EmailRouterBase
    {
        private Email _email;
        private IEmailValidatorService _emailValidatorService;

        public EmailRouterBase(Email email, IEmailValidatorService emailValidatorService)
        {
            _email = email;
            _emailValidatorService = emailValidatorService;
        }

        public virtual bool ValidateEmail()
        {
            return _emailValidatorService.ValidateEmail(_email);
        }

        public abstract void SendEmail();
    }
}
