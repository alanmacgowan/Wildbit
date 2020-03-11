using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageRouter.Validation
{
    public interface IEmailValidatorService
    {
        bool ValidateEmail(Email email);
    }
}
