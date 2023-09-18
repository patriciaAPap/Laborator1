using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex1
             * 
            Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui paralelipiped dreptunghic, va afisa volumul lui*/
            
            Console.WriteLine("Introudceti dimensiunile paralelipipedului dreptunghic:");
            int dimensiune1Paralelipiped = int.Parse(Console.ReadLine());

            int dimensiune2Paralelipiped = int.Parse(Console.ReadLine());

            int dimensiune3Paralelipiped = int.Parse(Console.ReadLine());

            int volumParalelipiped = dimensiune1Paralelipiped * dimensiune2Paralelipiped * dimensiune3Paralelipiped;


            Console.WriteLine("Volumul paralelipipedului dreptunghic este " + volumParalelipiped + ".");

            Console.ReadKey();
        }
    }
}
