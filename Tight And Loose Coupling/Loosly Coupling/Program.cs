using System.Runtime.InteropServices;

namespace Loosly_Coupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceModde = NotifacationModeFactory.Create(NotifacationMode.Email);
            NotificationService notification = new NotificationService(serviceModde);
            notification.Notify();
        }
    }

    enum NotifacationMode
    {
        Email,
        Sms
    }
    class NotifacationModeFactory
    {
        public static INotificationMode Create(NotifacationMode notifacationMode)
        {
            switch (notifacationMode)
            {
                case NotifacationMode.Email:
                    return new EmailService();

                case NotifacationMode.Sms:
                    return new SmsService();

                default:
                    return new EmailService();
            }
        }
    }


    interface INotificationMode
    {
        void Send();
    }
    class SmsService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("Sms sent");
        }
    }
    class EmailService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("Email sent");
        }
    }
    class NotificationService                                                    // Your task is only to report and not to specify the method, but I will tell you what the method is.
    {
        private readonly INotificationMode _notificationMode;
        public NotificationService(INotificationMode notificationMode)     
        {
            _notificationMode = notificationMode;
        }

        public void Notify()
        {
            _notificationMode.Send();
        }

    }
}