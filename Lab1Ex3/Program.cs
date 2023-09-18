using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Ex3
          Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastatura:*/


            Console.WriteLine("Introudceti un numar intreg din mai multe cifre:");

            int numarIntreg = int.Parse(Console.ReadLine());

            int lastNumber = numarIntreg % 10;

            Console.WriteLine("Ultima cifra a numarului intreg introdus este " + lastNumber + ".");

            /*Aici nu am stiut cum sa rezolv eroarea in caz ca inserez un numar foarte mic sau foarte mare: "Value was either too large or too small for an Int32". 
             * Cum as fi putut sa fac?*/

            Console.ReadKey();
        }
    }
}
