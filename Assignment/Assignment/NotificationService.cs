using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class NotificationService
    {
        private readonly INotificationRepository _repository;

        public NotificationService(INotificationRepository repository)
        {
            _repository = repository;
        }

        public void DisplayChannels(string title)
        {
            var notification = _repository.ParseNotification(title);
            var channels = _repository.GetChannels(notification);

            if (channels.Count > 0)
            {
                Console.WriteLine("Receive channels: " + string.Join(", ", channels));
            }
            else
            {
                Console.WriteLine("No relevant channels found.");
            }
        }
    }
}
