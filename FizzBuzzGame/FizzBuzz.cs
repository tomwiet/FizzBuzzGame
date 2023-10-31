using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
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

            else if (number % 3 == 0)
                return "Fizz";

            else if (number % 5 == 0)
                return "Buzz";
            else
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
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Miałes podac liczbe!");
                    continue;
                }
                return number;
            }
            
        }

        public void IfStopGame()
        {
            
            while (true) 
            {
                Console.WriteLine("Gramy dalej? [T/n]");
                
                var key = Console.ReadLine();
                
                if (key.ToUpper() == "N")
                    Environment.Exit(0);
                
                if(key.ToUpper()=="T")
                    break;
            }
            

        }

    }
}
