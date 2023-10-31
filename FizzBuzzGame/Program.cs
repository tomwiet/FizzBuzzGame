using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
