using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public class Email
    {
        public string From { get; set; }
        public List<string> To { get; set; }
        public List<string> Cc { get; set; }
        public List<string> Bcc { get; set; }
        public string Subject { get; set; }
        public string Tag { get; set; }
        public string HtmlBody { get; set; }
        public string TextBody { get; set; }
        public string ReplyTo { get; set; }
        public List<string> Headers { get; set; }
        public List<string> Attachments { get; set; }
        public int Type { get; set; }
    }
}
