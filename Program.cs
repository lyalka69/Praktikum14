using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace praktikum_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Пракикум 12 - Сакары Анны";

            //Задание 1. Вывести на экран в столбик первые 10 натуральных чисел (циклы с условием, цикл с параметром)
            int number = 1;
            while (number <= 10)
            {
                Console.WriteLine(number);
                number++;
            }

            number = 1;
            do
            {
                Console.WriteLine(number);
                number++;
            }
            while (number <= 10);

            for (number = 1; number <= 10; number++)
                Console.WriteLine(number);
            Console.ReadKey();

            //Задание 2. Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
            Console.Write("Введите значение для n: ");
            int n = int.Parse(Console.ReadLine()), num = 1;
            for (num = 1; num <= n; num++)
                Console.WriteLine(num);

            //Задание 3. Вывести в столбик 5 раз слово «Привет!» (циклы с условием)
            int word = 1;
            while (word <= 5)
            {
                Console.WriteLine("Hello!");
                word++;
            }
            word = 1;
            do
            {
                Console.WriteLine("Привет!");
                word++;
            }
            while (word <= 5);

            //Задание 4. С использованием цветового оформления консоли:

            //а) вывести на экран горизонтальную строку из 18 символов;

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            int length = 25, i = 0;

            length = 18;
            for (i = 0; i < length; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
            
            //б) вывести на экран вертикальную строку из 25 символов.
            
            for (i = 0; i < length; i++)
            {
                Console.WriteLine("|");
            }
            Console.ReadKey();
            

        }
    }
}
