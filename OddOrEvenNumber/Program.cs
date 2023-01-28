using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę, a ja odpowiem czy jest to liczba parzysta bądź nieparzysta.");

            while (true)
            {
                var inputNumber = ValidationData();

                if (inputNumber % 2 == 0)
                {
                    Console.WriteLine("Podałeś parzystą liczbę");
                }
                else// if (inputNumber % 0 == 1)
                {
                    Console.WriteLine("Podałeś nieparzystą liczbę");
                }
                Console.WriteLine("Podaj następną liczbę. Jeśli chcesz wyjsc to podaj literę 'T'.");               
            }                              
        }
        private static int ValidationData()
        {
            while (true)
            {
                var val = Console.ReadLine();
                if(val.ToUpper() == "T")
                {
                    Environment.Exit(0);
                }
                if (!int.TryParse(val, out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane.");
                }            
                else
                return number;

            }
        }
    }
}
