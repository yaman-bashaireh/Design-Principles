using System.Diagnostics.Metrics;

namespace UsingISP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var employees = Repository.LoadEmployees();

            foreach (var e in employees)
            {
                Console.WriteLine(e.PrintSalarySlip());
                Console.WriteLine();
            }
        }
    }
}
