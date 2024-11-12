using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment
{
    public class NotificationRepository:INotificationRepository
    {
        private readonly HashSet<string> _validChannels = new HashSet<string>() { "BE", "FE", "QA", "Urgent" };
        public Notification ParseNotification(string title)
        {
            var notification = new Notification(title);

            var tags = ExtractTags(title);

            foreach (var tag in tags)
            {
                if (_validChannels.Contains(tag))
                {
                    notification.Channels.Add(tag);
                }
            }

            return notification;

        }
        public List<string> GetChannels(Notification notification)
        {
            return notification.Channels;
        }
        private List<string> ExtractTags(string input)
        {
            var tags = new List<string>();
            var regex = new Regex(@"\[(.*?)\]");
            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                tags.Add(match.Groups[1].Value);
            }

            return tags;
        }
    }
}
