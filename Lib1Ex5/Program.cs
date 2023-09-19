using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib1Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex5
          Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.*/


            /*varianta mea*/

            Console.WriteLine("Introudceti un numar:");

            var primulNumarIntrodus = int.Parse(Console.ReadLine());
            var alDoileaNumarIntrodus = int.Parse(Console.ReadLine());


            if (primulNumarIntrodus < alDoileaNumarIntrodus)
            {
                Console.WriteLine(primulNumarIntrodus + "," + alDoileaNumarIntrodus);
            }

            else
            {
                Console.WriteLine(alDoileaNumarIntrodus + "," + primulNumarIntrodus);
            }

            Console.ReadKey();




            /*varianta cu ce am gasit pe internet*/
            Console.WriteLine("Introudceti un doua numere diferite:");

            var primulNumar = int.Parse(Console.ReadLine());
            var alDoileaNumar = int.Parse(Console.ReadLine());
                        
            int[] myNumbers = { primulNumar, alDoileaNumar };
            Array.Sort(myNumbers);
            for (int i =0; i< myNumbers.Length; i++ )
            
                Console.WriteLine(myNumbers[i]);
       
            Console.ReadKey();


        }
    }
}
