using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LogicalPrograms.FibonacciSeries;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public void Print(int num)
        {
            int firstNum = 0, secondNum = 1, thirdNum = 0;
            Console.WriteLine(firstNum + "\n" + secondNum);
            for (int i = 0; i < num; i++)
            {
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                Console.WriteLine(thirdNum);
            }
        }
        public class PrimeNumber
        {
            public void CheckPrime(int num)
            {
                int count = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                        count++;
                }
                if (count == 2)
                    Console.WriteLine("Number is Prime");
                else
                    Console.WriteLine("Number is not a Prime");
            }
        }
        public class CouponNum
        {

            public void CouponNumber()
            {
                int[] arr = new int[10];
                int[] distArr = new int[10];
                Random random = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(1, 11);
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[i].Equals(arr[j]))
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        distArr[i] = arr[i];
                    }
                }
                foreach (var data in distArr)
                {
                    if (data != 0)
                    {
                        Console.WriteLine(data);
                    }
                }
            }
            internal class MonthlyPayment
            {
                double P, V, J, n, r, payment;
                public void Payment()
                {
                    Console.WriteLine("Enter principle amount", P);
                    P = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter number of year", V);
                    V = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter rate of interest", J);
                    J = Convert.ToDouble(Console.ReadLine());
                    n = (12 * V);
                    Console.WriteLine("Number: " + n);
                    r = J / (12 * 100);
                    Console.WriteLine("rate: " + r);
                    payment = ((P * r) / (1 - Math.Pow(1 + r, -n)));
                    Console.WriteLine("Monthly Payment: " + payment);

                }
            }
        }
        public class ReverseNo
        {
            int revNum = 0;
            public void NumberCheck()
            {
                Console.WriteLine("Enter No");
                int num = Convert.ToInt32(Console.ReadLine());
                while (num > 0)
                {
                    int reminder = num % 10;
                    revNum = revNum * 10 + reminder;
                    num = num / 10;
                }
                Console.WriteLine(revNum);
            }
        }
        public class StopWatch
        {
            public void calElapsedTime()
            {
                // Create new stopwatch
                Stopwatch stopwatch = new Stopwatch();

                // Begin time
                stopwatch.Start();

                // Do something
                for (int i = 0; i < 1000; i++)
                {
                    Thread.Sleep(1);
                }

                // Stop timing
                stopwatch.Stop();

                // result
                Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            }

        }
        public class TempConversion
        {
            double f, c;
            public void Conversion()
            {
                Console.WriteLine("choose type of conversion\n 1. Fahrenheit to Celsius\n 2. Celsius to Fahrenheit");
                int conversion = Convert.ToInt32(Console.ReadLine());
                switch (conversion)
                {
                    case 1:
                        Console.WriteLine("Enter fahrenheit temp", f);
                        f = Convert.ToDouble(Console.ReadLine());
                        c = (f - 32) * 5 / 9;
                        Console.WriteLine("Celsius temperature: " + c);
                        break;
                    case 2:
                        Console.WriteLine("Enter celsius temp", c);
                        c = Convert.ToDouble(Console.ReadLine());
                        f = ((9 * c) / 5) + 32;
                        Console.WriteLine("Fahrenheit temperature: " + f);
                        break;
                    default:
                        Console.WriteLine("Enter valid conversion");
                        break;
                }
            }
            internal class DayOfWeeks
            {
                public static void dayOfWeeks()
                {
                    Console.Write("Enter the months : ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the days : ");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the year : ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    int y0 = y - (14 - m) / 12;
                    int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                    int m0 = m + 12 * ((14 - m) / 12) - 2;
                    int d0 = (d + x + (31 * m0) / 12) % 7;
                    switch (d0)
                    {
                        case 0:
                            Console.WriteLine("Sunday");
                            break;
                        case 1:
                            Console.WriteLine("Monday");
                            break;
                        case 2:
                            Console.WriteLine("Tuesday");
                            break;
                        case 3:
                            Console.WriteLine("Wednesday");
                            break;
                        case 4:
                            Console.WriteLine("Thursday");
                            break;
                        case 5:
                            Console.WriteLine("Friday");
                            break;
                        case 6:
                            Console.WriteLine("Saturday");
                            break;
                    }
                }
                internal class WeekDay
                {
                    int day, month, year;

                    public void CalDay()
                    {

                        int x, days, months, years;
                        Console.Write("\n");
                        Console.Write("To Print Day Of Week:\n");
                        Console.Write("\n");
                        Console.WriteLine("Please Enter the Date");
                        day = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please Enter the Month");
                        month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please Enter the Year");
                        year = Convert.ToInt32(Console.ReadLine());

                        years = year - (14 - month) / 12;
                        x = years + years / 4 - years / 100 + years / 400;
                        months = month + 12 * ((14 - month) / 12) - 2;
                        days = (day + x + 31 * months / 12) % 7;
                        Console.WriteLine("Calculate the day as per: \n Monday = 1 \n Tuesday = 2 \n Wednesday = 3 \n Thursday = 4 \n Friday = 5 \n Saturday = 6 \n Sunday = 0");
                        Console.WriteLine(days + " is the day of the Week that date Falls On " + day + "/" + month + "/" + year + ".");
                    }
                }
            }
        }
    }
}
        

       





        
   