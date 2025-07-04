using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace BeforeUsingISP
{
    internal partial class Program
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