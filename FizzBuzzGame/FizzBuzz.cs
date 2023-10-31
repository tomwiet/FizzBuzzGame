using System;

namespace FizzBuzzGame
{/// <summary>
/// FizzBuzz game class
/// </summary>
    internal class FizzBuzz
    {   /// <summary>
        /// Say Fizz, Buzz or FizzBuzz
        /// </summary>
        /// <param name="number" >number to check</param>
        /// <returns>
        /// "Fizz string for numbers divisible by 3;
        /// "Buzz" string for number didisible by 5;
        /// "FizzBuzz" string for number divisible by 3 and 5;
        /// That number as string if none of above;
        /// </returns>
        public string SayFizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }
        /// <summary>
        /// Get input from console, try parse to int
        /// </summary>
        /// <returns>Number get from user console</returns>
        public int GetNumber()
        {
            while (true)
            {
                Console.WriteLine("Podaj liczbę: ");

                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Miałes podac liczbe!");
                    this.IfStopGame();
                    continue;
                }
                return number;
            }

        }
        /// <summary>
        /// Ask user if stop game or play again
        /// </summary>
        public void IfStopGame()
        {

            while (true)
            {
                Console.WriteLine("Gramy dalej? [t/n]");

                var key = Console.ReadLine();

                if (key.ToUpper() == "N")
                    Environment.Exit(0);

                else if (key.ToUpper() == "T")
                    break;
                else
                    Console.WriteLine("Wpisz t lub n");
            }


        }

    }
}
