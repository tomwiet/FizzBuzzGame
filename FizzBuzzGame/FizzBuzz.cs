using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class FizzBuzz
    {
        public string SayFizzBuzz(int number) 
        {

            return number.ToString();
        }
        /// <summary>
        /// Get input from console, try parse to int
        /// </summary>
        /// <returns>Number get from user console</returns>
        public int getNumber()
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
    }
}
