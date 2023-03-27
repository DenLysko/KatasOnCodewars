using System;
using System.ComponentModel.DataAnnotations;

namespace Katas
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(digPow(46288, 3)); // 51
            Console.WriteLine(digPow(89, 1));    // 1
            Console.WriteLine(digPow(92, 1));    // -1
        }


        // Playing with digits
        public static long digPow(int n, int p)
        {
            var digitsArr = ToDigitsArr(n);

            var leftPart = GetLeftPart(digitsArr, p);
            var remainder = leftPart % n;

            return remainder == 0 ? leftPart / n : -1;

            int[] ToDigitsArr(int number)
            {
                var digitsList = new List<int>();
                var tmpNumber = number;

                while (tmpNumber > 0)
                {
                    digitsList.Add(tmpNumber % 10);
                    tmpNumber /= 10;
                }
                var result = digitsList.ToArray();
                Array.Reverse(result);
                return result;
            }

            long GetLeftPart(int[] digitsArr, int p)
            {
                long result = 0;
                for (int i = 0; i < digitsArr.Length; i++)
                    result += Convert.ToInt64(Math.Pow(digitsArr[i], (p + i)));
                return result;
            }
        }


    }
}