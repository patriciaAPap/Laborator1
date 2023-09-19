using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex 4
Scrieti un program care va afisa semnul unui numar citit de la tastatura
• Daca numarul este pozitiv, va afisa “+”
• Daca numarul este negativ, va afisa “-”
• Daca numarul este 0, va afisa “0”*/


            Console.WriteLine("Introudceti un numar:");

            int numarIntrodus = int.Parse(Console.ReadLine());

            if (numarIntrodus == 0)
            {

                Console.WriteLine("0");

            }

            else

            {
                if (numarIntrodus%2 == 0)
                {
                    Console.WriteLine("+");
                }

                else
                {
                    Console.WriteLine("-");
                }

            }


            Console.ReadKey();


        }
    }
}
