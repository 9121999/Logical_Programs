using System;
using System.Collections.Generic;
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
        }
    }
}
   