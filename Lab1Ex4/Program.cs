﻿using System;
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

            double numarIntrodus = double.Parse(Console.ReadLine());

            if (numarIntrodus == 0)
            {
                Console.WriteLine("0");
                Console.ReadKey();
            } 
            
            else if (numarIntrodus > 0)
            {
                Console.WriteLine("+");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("-");
                Console.ReadKey();

            }

        }




        }
    }

