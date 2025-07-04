namespace UsingLSP
{
    abstract class RegularAccount : Account
    {
        protected RegularAccount(string name, decimal balance) : base(name, balance)
        {
        }

        public abstract void Withdraw(decimal amount);
    }
}