using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public interface INotificationRepository
    {
        Notification ParseNotification(string title);
        List<string> GetChannels(Notification notification);
    }
}
