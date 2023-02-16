using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("................FizzBuzz.................");
        for(int i=1; i<=100; i++)
        {
            Console.WriteLine(
                (i%3 == 0)? "Fizz":
                (i%5 == 0)? "Buzz":
                (i % 15 == 0) ? "FizzBuzz" :
                i
                );
        }
    }
}