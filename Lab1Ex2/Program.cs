using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Ex2
            Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura*/


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
