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
            Console.WriteLine("Podaj liczbę: ");
            
            
            while (true) 
            {
                var number = fizBuzz.getNumber();
                Console.WriteLine(fizBuzz.SayFizzBuzz(number));
                break;
            }
            Console.ReadLine();
        }
    }
}
