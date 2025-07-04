using System.Diagnostics.Metrics;

namespace Single_Responsibility_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestWithSRP();
        }


        private static void TestWithSRP()
        {
            var account = new After.Account("Yaman", "Yaman.albashairehh@gmail.com", 10500);

            var accountService = new After.AccountService();

            accountService.Deposit(account, 500);
            accountService.WithDraw(account, 11000);
        }

        private static void TestWithoutSRP()
        {
            var account = new Before.Account("Reem", "reem@example.com", 10000m);
            account.MakeTransaction(500);
            account.MakeTransaction(-11000);
        }

    }
}