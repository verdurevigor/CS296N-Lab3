using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EugeneCommunity.Models
{
    public class Topic
    {
        public virtual int TopicId { get; set; }
        public virtual string Name { get; set; }
    }
}