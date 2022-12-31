using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encorder = new VideoEncorder();
            encorder.RegisterNotificationChannel(new MailNotificationChannel());
            encorder.RegisterNotificationChannel(new SmsNotificationChannel());
            encorder.Encode(new Video());
        }
    }
}
