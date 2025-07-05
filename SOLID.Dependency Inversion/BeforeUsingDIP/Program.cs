namespace BeforeUsingDIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = Repository.Customers;

            foreach (var customer in customers)
            {
                var notificationService = new NotificationService(customer);
                notificationService.Notify();
                Console.WriteLine( "\n");
            }
        }
    }
}