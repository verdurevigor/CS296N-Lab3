using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EugeneCommunity.Models
{
    public class EugeneCommunityInitializer : System.Data.Entity.DropCreateDatabaseAlways<EugeneCommunityContext>
    {
        protected override void Seed(EugeneCommunityContext context)
        {
            Topic t1 = new Topic { TopicId = 1, Name = "IPA Crave" };
            Topic t2 = new Topic { TopicId = 2, Name = "Beer Tasting" };
            context.Topics.Add(t1);
            context.Topics.Add(t2);

            Member m1 = new Member { MemberId = 1, Name = "Brody", Email = "brodyjcase@gmail.com", Password = "Passw0rd", IsAdmin = true};
            Member m2 = new Member { MemberId = 2, Name = "Zach", Email = "beerlove@gmail.com", Password = "Passw0rd", IsAdmin = false };

            context.Messages.Add(new Message { 
                MessageId = 1,
                Subject = t1,
                Body = "HUB (Hopwors Urban Brewery) makes my favorite IPA as of now. They source a single hop called the Simcoe, it's grown in Washington. Not to bitter, but a smooth, crisp flavor jumps out at you. I love all the organic beer that HUB crafts. Give it a try!",
                Date = DateTime.Now.AddHours(2),
                Sender = m1
            });

            context.Messages.Add(new Message
            {
                MessageId = 2,
                Subject = t2,
                Body = "With so many pourhouses here in Eugene, where do you even start?! Well, I'll give you a shortened list to tackle: Falling Sky Delicatessen, The Bier Stein, The Tap and Growler. Pick one and have fun tasting!",
                Date = DateTime.Now.AddHours(4),
                Sender = m2
            });

            context.Messages.Add(new Message
            {
                MessageId = 3,
                Subject = t1,
                Body = "While typically a Summer seasonal beer, Pelican Brewery currently is putting out their 'Umbrella' IPA. It's supreme. Although, pelicans really are nasty birds.",
                Date = DateTime.Now.AddMinutes(30),
                Sender = m1
            });

            base.Seed(context);
        }
    }
}