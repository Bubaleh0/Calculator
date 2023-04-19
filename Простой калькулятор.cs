using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'y';
            while (again == 'y')
            {
                double total;
                Console.WriteLine("Введите первое число");
                var a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберите действие(+, -, *, /, ^)");
                var oper = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                var b = Convert.ToDouble(Console.ReadLine());
                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine($"{a} + {b} = {total}.");
                }
                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine($"{a} - {b} = {total}.");
                }
                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine($"{a} * {b} = {total}.");
                }
                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine($"{a} / {b} = {total}.");
                }
                else if (oper == '^')
                {
                    total = Math.Pow(a, b);
                    Console.WriteLine($"{a} ^ {b} = {total}.");
                }
                else
                {
                    Console.WriteLine("Ошибка! Неверно введено действие.");
                }
                Console.WriteLine("Хотите продолжить работу с программой? (y/n)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}