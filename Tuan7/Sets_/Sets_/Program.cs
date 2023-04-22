using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> setA = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> setB = new HashSet<int>() { 3, 4, 5, 6, 7 };

        Console.WriteLine("Set A: " + string.Join(", ", setA));
        Console.WriteLine("Set B: " + string.Join(", ", setB));

        // union of setA and setB
        setA.UnionWith(setB);
        Console.WriteLine("Union of Set A and Set B: " + string.Join(", ", setA));

        // intersection of setA and setB
        setA.IntersectWith(setB);
        Console.WriteLine("Intersection of Set A and Set B: " + string.Join(", ", setA));

        // difference of setA and setB
        setA.ExceptWith(setB);
        Console.WriteLine("Difference of Set A and Set B: " + string.Join(", ", setA));

        Console.ReadKey();
    }
}

