using System;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fizBuzz = new FizzBuzz();

            while (true)
            {

                var number = fizBuzz.GetNumber();

                Console.WriteLine(fizBuzz.SayFizzBuzz(number));

                fizBuzz.IfStopGame();

            }
        }
    }
}
