using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2Var
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 5, 2, 9, 1, 5, 6 };
            int maxNumber = MaxFinder.GetMax(numbers);
            Console.WriteLine($"Максимальное число: {maxNumber}");
            Console.ReadKey();
        }
    }

    public class MaxFinder
    {
        public static int GetMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            return max;
        }
    }

}

