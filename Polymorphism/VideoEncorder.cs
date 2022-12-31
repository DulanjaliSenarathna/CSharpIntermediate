using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class VideoEncorder
    {
        private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncorder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            //Video encoding logic
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
           
        }

        

        public void RegisterNotificationChannel(INotificationChannel channel)//tell video encorder about the actual notification channels at runtime.
        {
            _notificationChannels.Add(channel);
        }
    }
}
