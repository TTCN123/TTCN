using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 8, 2, 7, 1, 6, 3, 9, 4 };

        var filteredNumbers = from num in numbers
                              where num % 2 == 0 && num > 4
                              orderby num descending
                              select num;

        Console.WriteLine("Even numbers greater than 4 in descending order:");
        foreach (var num in filteredNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
