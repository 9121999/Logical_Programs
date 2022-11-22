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
                Console.WriteLine("\nselect Program\n 1.FibonacciSeries\n 2.Prime No \n 3.CouponNumber \n 4.MonthlyPayment \n 5.ReverseNumber \n 6.StopWatch \n 7.TempConversion");
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
                    case 5:
                        ReverseNo rev = new ReverseNo();
                        rev.NumberCheck();
                        break;
                    case 6:
                        StopWatch watch= new StopWatch();
                        watch.calElapsedTime();
                        break;
                    case 7:
                        TempConversion temp = new TempConversion();
                        temp.Conversion();
                            break;


                }
            }

        }
    }
}