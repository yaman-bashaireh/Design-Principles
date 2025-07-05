namespace Tightly_Coupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService(new EmailService(), new SmsService());

            notificationService.Notify();
        }
    }

    class SmsService 
    {
        public void Send()
        {
            Console.WriteLine("Sms sent");
        }
    }
    class EmailService 
    {
        public void Send()
        {
            Console.WriteLine("Email sent");
        }
    }

    class NotificationService
    {
        private readonly EmailService _emailService;       // Tightly Coupling 
        private readonly SmsService _SmsService;           // ...........
        public NotificationService(EmailService emailService, SmsService smsService)             //May have more services in future, So there is many injection Unfortunately.
        {
            _emailService = emailService;
            _SmsService = smsService;
        }
        public void Notify()
        {
            _emailService.Send();
            _SmsService.Send();
        }
    }
}