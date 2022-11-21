using LogicalPrograms;
using static LogicalPrograms.FibonacciSeries;

namespace LogicalProgramms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nselect Program\n 1.FibonacciSeries\n 2.Prime No");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.Print(12);
                        break;
                    case 3:
                        PrimeNumber primeNo = new PrimeNumber();
                        primeNo.CheckPrime(10);
                        break;
                }
            }

        }
    }
}