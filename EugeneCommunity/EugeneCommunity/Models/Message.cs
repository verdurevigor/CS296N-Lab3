using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EugeneCommunity.Models
{
    public class Message
    {
        public virtual int MessageId { get; set; }
        public virtual Topic Subject { get; set; }
        public virtual string Body { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Member Sender { get; set; }
    }
}