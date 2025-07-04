namespace UsingLSP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var account = new FixedDepositAccount("yaman", 10_000);

            account.Withdraw(1000);        // won't work
        }
    }
}