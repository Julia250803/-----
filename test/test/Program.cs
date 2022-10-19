using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, z;
            
            Console.WriteLine("Введите первое число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите число: 1. Выполнить сложение. 2. Выполнить вычитание. 3. Выполнить умножение. 4. Выполнить деление");
            z = Convert.ToInt32(Console.ReadLine());




        }
    }
}
