using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1Ex7
{
    class Program
    {
        static void Main(string[] args)
        {/*Ex7
          Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar
           - In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.*/

            Console.WriteLine("Introudceti un numar:");

            int numarIntrodus = int.Parse(Console.ReadLine());
                       

                if (numarIntrodus % 2 == 0)
                {
                    Console.WriteLine("par");
                }

                else
                {
                    Console.WriteLine("impar");
                }

                        Console.ReadKey();
        }
    }
}
