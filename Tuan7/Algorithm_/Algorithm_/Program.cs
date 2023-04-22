using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Min_max();
        Fibonacci(5);
    }
    public static void Min_max()
    {
        int[] numbers = { 3, 9, 4, 5, 1, 8, 2, 7, 6 };
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("Min value: " + min);
        Console.WriteLine("Max value: " + max);
    }
    public static long Fibonacci(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
