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
        internal class StopWatch
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
        internal class TempConversion
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
        }
    }

}



        
   