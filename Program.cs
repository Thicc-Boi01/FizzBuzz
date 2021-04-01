using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
        for (int Number = 1; Number <= 100; Number++) {
            if (Number % 3 == 0 && Number % 5 == 0) 
            {
               Console.WriteLine("FizzBuzz");
            }
            if (Number % 3 == 0) 
            {
               Console.WriteLine("Fizz");
            }
            if (Number % 5 == 0) 
            {
               Console.WriteLine("Buzz");
            }
               Console.WriteLine(Number);
            }
        }
    }
}
