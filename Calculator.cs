using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR12
{
    internal class Calculator
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine($"Сумма = {a + b} ");
        }
        public static void Subtraction(int a, int b)
        {
            Console.WriteLine($"Разница = {a - b}");
        }
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine($"Произведение = {a * b}");
        }
        public static void Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Деление на ноль невозмонжо");
                return;
            }
            Console.WriteLine($"Частность = {(double)a / (double)b}");
        }
    }
}
