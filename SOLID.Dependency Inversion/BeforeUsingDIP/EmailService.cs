
namespace BeforeUsingDIP
{
    internal class EmailService
    {
        public string EmailAddress { get; set; }         

        public void Send()
        {
            Console.WriteLine($"e-mail is sent to {EmailAddress}");
        }
    }
}
