using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 6, 7, 10, 20, 23, 30, 51, 100, 999, 10000 };

        Console.WriteLine("Even numbers:");
        foreach (int num in numbers)
        {
            if (num.IsEven())
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Odd numbers:");
        foreach (int num in numbers)
        {
            if (num.IsOdd())
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine(); 
    }
}
