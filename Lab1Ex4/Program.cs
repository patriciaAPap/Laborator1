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


            Console.WriteLine("Introudceti numerele pentru media aritmetica:");

            int primulNumar = int.Parse(Console.ReadLine());

            int alDoileaNumar = int.Parse(Console.ReadLine());

            int alTreileaNumar = int.Parse(Console.ReadLine());

            int mediaAritmeticaATreiNumere = (primulNumar + alDoileaNumar + alTreileaNumar) / 3;


            Console.WriteLine("Media aritmetica este " + mediaAritmeticaATreiNumere + ".");

            Console.ReadKey();


        }
    }
}
