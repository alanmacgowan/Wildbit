using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Events
{
    public class SendEmailEvent
    {
        public Email  Email { get; set; }
    }
}
