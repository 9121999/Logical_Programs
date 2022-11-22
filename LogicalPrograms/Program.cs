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
                Console.WriteLine("\nselect Program\n 1.FibonacciSeries\n 2.Prime No \n 3.CouponNumber");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.Print(12);
                        break;
                    case 2:
                        PrimeNumber primeNo = new PrimeNumber();
                        primeNo.CheckPrime(2);
                        break;
                    case 3:
                        CouponNum coupen = new CouponNum();
                        coupen.CouponNumber();
                        break;
                }
            }

        }
    }
}