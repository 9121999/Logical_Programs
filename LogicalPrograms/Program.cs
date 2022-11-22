using LogicalPrograms;
using static LogicalPrograms.FibonacciSeries;
using static LogicalPrograms.FibonacciSeries.CouponNum;

namespace LogicalProgramms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nselect Program\n 1.FibonacciSeries\n 2.Prime No \n 3.CouponNumber \n 4.MonthlyPayment");
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
                    case 4:
                        MonthlyPayment monthly = new MonthlyPayment();
                        monthly.Payment();
                        break;
                }
            }

        }
    }
}