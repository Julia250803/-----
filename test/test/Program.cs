﻿using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {


            double a, b, z;
  
            z = 0;
            a = 0;
            b = 0;
            Console.WriteLine("Введите первое число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToDouble(Console.ReadLine());
            switch (z)
            {
                case 1:
                    Console.WriteLine(a + b);
                    break;
                case 2:

                case 3:

                case 4:

                default:
                    Console.WriteLine("Такого варианта нет");
                    break;
            }
        }
    }
}
